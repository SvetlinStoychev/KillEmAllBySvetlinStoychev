using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillEmAll
{
    class Me
    {
        private int leftElement;
        private int middleElement;
        private int rightElement;

        public Me(int leftElement, int middleElement, int rightElement)
        {
            this.leftElement = leftElement;
            this.middleElement = middleElement;
            this.rightElement = rightElement;
        }

        public int LeftElement
        {
            get { return this.leftElement; }
            set { this.leftElement = value; }
        }
        public int MiddleElement
        {
            get { return this.middleElement; }
            set { this.middleElement = value; }
        }
        public int RightElement
        {
            get { return this.rightElement; }
            set { this.rightElement = value; }
        }
    }
}
