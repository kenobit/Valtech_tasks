using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Arrays
{
    public class Link
    {
        public BTLNode Node;
        public Link()
        {
            this.Node = new BTLNode();
        }
    }

    public class BTLNode
    {
        public BTLNode leftNode;
        public BTLNode rightNode;
        public BTLNode parentNode;
        public int value;

        public BTLNode()
        {
            this.leftNode = null;
            this.rightNode = null;
            this.parentNode = null;
        }
        public BTLNode(BTLNode parent, int value)
        {
            this.parentNode = parent;
            this.value = value;
        }
    }
    public class BinaryTreeLink
    {
        /// <summary>
        /// Node class for binary
        /// </summary>


        Link rootNode;
        private int size;
       // public int Size { get { return size; } }


        public BinaryTreeLink()
        {
            rootNode.Node = null;
            this.size = 0;
        }
        public BinaryTreeLink(BTLNode rt)
        {
            this.rootNode.Node = rt;
            this.size = 0;
        }

        public void Add(int value) //3
        {
            if (rootNode.Node != null)
            {
                Link current = rootNode;
                bool added = false;
                while (!added)
                {
                    if (current.Node.value == value)
                    {
                        added = !added;
                    }
                    else
                    {
                        if (current.Node.value > value)
                        {
                            if (current.Node.leftNode != null)
                            {
                                current.Node = current.Node.leftNode;
                            }
                            else
                            {
                                current.Node.leftNode = new BTLNode(current.Node, value);
                                this.size++;
                                added = !added;
                            }
                        }
                        else
                        {
                            if (current.Node.rightNode != null)
                            {
                                current.Node = current.Node.rightNode;
                            }
                            else
                            {
                                current.Node.rightNode = new BTLNode(current.Node, value);
                                this.size++;
                                added = !added;
                            }
                        }
                    }
                }
            }
            else
            {
                this.size++;
                rootNode.Node = new BTLNode(null, value);
            }
        }

        public void Init(int[] array)
        {
            this.Clear();
            foreach (var item in array) { this.Add(item); }
        }

        public void Clear()
        {
            rootNode.Node = new BTLNode();
        }

        public override string ToString()
        {
            string str = "";
            foreach (var item in this.ToArray())
            {
                str += item + " ";
            }
            return str;
        }

        public int[] ToArray()
        {
            if (rootNode.Node == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                return (BinaryTreeLink.ToArray(rootNode.Node)).ToArray();
            }
        }
        private static List<int> ToArray(BTLNode tree)
        {
            if (tree == null) return new List<int>();
            var result = ToArray(tree.leftNode);
            result.Add(tree.value);
            result.AddRange(ToArray(tree.rightNode));
            return result;
        }

        /// <summary>
        /// Helps definition))
        /// </summary>
        public enum Side
        {
            Left,
            Right
        }

        /// <summary>
        /// Check parental branch which contains currnt node
        /// </summary>
        /// <param name="node">current.Node node</param>
        /// <returns>Side</returns>
        private Side? MeForParent(BTLNode node)
        {
            if (node.parentNode == null) return null;
            if (node.parentNode.leftNode == node) return Side.Left;
            if (node.parentNode.rightNode == node) return Side.Right;
            return null;
        }
        private void Add(int value, BTLNode node, BTLNode parent)
        {

            if (node.value == value)
            {
                node.value = value;
                node.parentNode = parent;
                return;
            }
            if (node.value > value)
            {
                if (node.leftNode == null) node.leftNode = new BTLNode();
                Add(value, node.leftNode, node);
            }
            else
            {
                if (node.rightNode == null) node.rightNode = new BTLNode();
                Add(value, node.rightNode, node);
            }
        }
        private void Add(BTLNode data, BTLNode node, BTLNode parent)
        {

            if (node.value == data.value)
            {
                node.value = data.value;
                node.leftNode = data.leftNode;
                node.rightNode = data.rightNode;
                node.parentNode = parent;
                return;
            }
            if (node.value > data.value)
            {
                if (node.leftNode == null) node.leftNode = new BTLNode();
                Add(data, node.leftNode, node);
            }
            else
            {
                if (node.rightNode == null) node.rightNode = new BTLNode();
                Add(data, node.rightNode, node);
            }
        }

        public void Delete(BTLNode node)
        {
            if (node == null)
            {
                throw new NullReferenceException();
            }

            var me = MeForParent(node);
            if (node.leftNode == null && node.rightNode == null)
            {
                if (me == Side.Left)
                {
                    node.parentNode.leftNode = null;
                }
                else
                {
                    node.parentNode.rightNode = null;
                }
                return;
            }
            if (node.leftNode == null)
            {
                if (me == Side.Left)
                {
                    node.parentNode.leftNode = node.rightNode;
                }
                else
                {
                    node.parentNode.rightNode = node.rightNode;
                }

                node.rightNode.parentNode = node.parentNode;
                return;
            }
            if (node.rightNode == null)
            {
                if (me == Side.Left)
                {
                    node.parentNode.leftNode = node.leftNode;
                }
                else
                {
                    node.parentNode.rightNode = node.leftNode;
                }

                node.leftNode.parentNode = node.parentNode;
                return;
            }

            if (me == Side.Left)
            {
                node.parentNode.leftNode = node.rightNode;
            }
            if (me == Side.Right)
            {
                node.parentNode.rightNode = node.rightNode;
            }
            if (me == null)
            {
                var bufLeft = node.leftNode;
                var bufRightLeft = node.rightNode.leftNode;
                var bufRightRight = node.rightNode.rightNode;
                node.value = node.rightNode.value;
                node.rightNode = bufRightRight;
                node.leftNode = bufRightLeft;
                Add(bufLeft, node, node);
            }
            else
            {
                node.rightNode.parentNode = node.parentNode;
                Add(node.leftNode, node.rightNode, node.rightNode);
            }
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="value"></param>
        public void Delete(int value)
        {
            var removeNode = Find(value);
            if (removeNode != null)
            {
                Delete(removeNode);
            }
        }

        /// <summary>
        /// Tree counter
        /// </summary>
        /// <returns>Count of elements in the tree</returns>
        public int CountElements()
        {
            return CountElements(this.rootNode.Node);
        }
        /// <summary>
        /// Tree counter
        /// </summary>
        /// <param name="node">Root node</param>
        /// <returns>count of elements in the tree</returns>
        private int CountElements(BTLNode node)
        {
            int count = 1;
            if (node.rightNode != null)
            {
                count += CountElements(node.rightNode);
            }
            if (node.leftNode != null)
            {
                count += CountElements(node.leftNode);
            }
            return count;
        }

        /// <summary>
        /// Find node with current.Node value
        /// </summary>
        /// <param name="data">Value for search</param>
        /// <returns>Founded result</returns>
        public BTLNode Find(int value)
        {
            Link current = rootNode;

            if (current.Node.value == value) return current.Node;
            if (current.Node.value > value)
            {
                return Find(value, current.Node.leftNode);
            }
            return Find(value, current.Node.rightNode);
        }

        /// <summary>
        /// Find value in current.Node node
        /// </summary>
        /// <param name="value">Value for search</param>
        /// <param name="node">Node for search</param>
        /// <returns>Founded result</returns>
        public BTLNode Find(int value, BTLNode node)
        {
            if (node == null) return null;

            if (node.value == value) return node;
            if (node.value > value)
            {
                return Find(value, node.leftNode);
            }
            return Find(value, node.rightNode);
        }
    }
}
