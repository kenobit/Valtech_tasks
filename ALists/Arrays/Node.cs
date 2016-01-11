using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    /// <summary>
    /// Linked list helper class
    /// </summary>
    public class Node
    {

        private int value;
        private Node next;
        private Node prev;

        /// <summary>
        /// Value property
        /// </summary>
        public int Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        /// <summary>
        /// Next node property
        /// </summary>
        public Node Next
        {
            get
            {
                return this.next;
            }
            set
            {
                this.next = value;
            }
        }

        /// <summary>
        /// Previous node property
        /// </summary>
        public Node Prev
        {
            get
            {
                return this.prev;
            }
            set
            {
                this.prev = value;
            }
        }

        /// <summary>
        /// Constructor with value and next node parameters
        /// </summary>
        /// <param name="value">int</param>
        /// <param name="next">Node</param>
        public Node(int value, Node next)
        {
            this.Value = value;
            this.Next = next;
            this.Next.Prev = this;
        }

        /// <summary>
        /// Constructor with value, previous node and next node parameters 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="prev"></param>
        /// <param name="next"></param>
        public Node(int value, Node prev, Node next)
        {
            this.prev = prev;
            this.next = next;
            this.value = value;
        }

        /// <summary>
        /// Constructor with value parameter
        /// </summary>
        /// <param name="value">int</param>
        public Node(int value)
        {
            this.value = value;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Node()
        {

        }
    }
}
