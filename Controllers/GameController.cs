﻿using Microsoft.AspNetCore.Mvc;
using Milestone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milestone.Controllers
{
    public class GameController : Controller
    {
        static List<CellModel> cells = new List<CellModel>();

        Random rand = new Random();
        static int GRID_SIZE = 6;
        static bool gameStarted = false;
        static bool gameOver = false;
        public IActionResult Index()
        {
            if (!gameStarted)
            {
                int x = GRID_SIZE;
                int y = x;
                int id = 0;
                double difficulty = .1;
                int bombCount = (int)((double)difficulty * (GRID_SIZE * GRID_SIZE));
                int randRow, randCol;
                CellModel currCell;

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        cells.Add(new CellModel(id, 0, i, j));
                        id++;
                    }
                }

                while (bombCount > 0)
                {
                    randRow = rand.Next(x + 1);
                    randCol = rand.Next(y + 1);

                    currCell = cells.Find(cell => cell.Row == randRow && cell.Col == randCol);

                    if (currCell != null)
                    {
                        currCell.State = 1;
                        bombCount--;
                    }
                }

                gameStarted = true;
            }

            return View("Index", cells);
        }

        public IActionResult HandleLeftClick(string mine)
        {
            int buttonNumber = Int32.Parse(mine);

            if (cells[buttonNumber].State > 0)
            {
                gameOver = true;
                cells[buttonNumber].Visited = true;
            }
            else
            {
                FloodFill(cells[buttonNumber].Row, cells[buttonNumber].Col);
            }

            return View("Index", cells);
        }

        private int calculateLiveNeighbors(CellModel cell)
        {
            int x = cell.Row;
            int y = cell.Col;
            int size = (int)Math.Sqrt(GRID_SIZE);
            int liveNeghbors = 0;
            CellModel curCell;

            int[] xmove = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] ymove = { -1, -0, 1, -1, 1, -1, 0, 1 };

            if (cells.Find(cell => cell.Row == x && cell.Col == y).State > 0)
                liveNeghbors++;

            for (int i = 0; i < 8; i++)
            {
                curCell = cells.Find(cell => cell.Row == x + xmove[i] && cell.Col == y + ymove[i]);

                if (curCell != null && (x + xmove[i] >= 0 && y + ymove[i] >= 0 && curCell.State > 0))
                    liveNeghbors++;
            }

            return liveNeghbors;
        }

        public void FloodFill(int row, int col)
        {
            CellModel currCell = (cells.Find(cell => cell.Row == row && cell.Col == col));

            if (currCell == null || currCell.State > 0 || currCell.Visited)
            {
                return;
            }
            else
            {
                currCell.Neighbors = calculateLiveNeighbors(currCell);
                currCell.Visited = true;
            }

            if (currCell.Neighbors == 0)
            {
                int[] xmove = { -1, -1, -1, 0, 0, 1, 1, 1 };
                int[] ymove = { -1, -0, 1, -1, 1, -1, 0, 1 };

                for (int i = 0; i < 8; i++)
                {
                    FloodFill(row + xmove[i], col + ymove[i]);
                }
            }
        }
    }
}
