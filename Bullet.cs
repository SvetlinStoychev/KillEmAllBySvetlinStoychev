﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillEmAll
{
    class Bullet
    {
        private int row;
        private int col;

        public Bullet(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

        public int Row
        {
            get { return this.row; }
            set { this.row = value; }
        }
        public int Col
        {
            get { return this.col; }
            set { this.col = value; }
        }
    }
}
