using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Arrays
{
    public class BTNode
    {
        public BTNode leftNode;
        public BTNode rightNode;
        public BTNode parentNode;
        public int value;

        public BTNode()
        {
            this.leftNode = null;
            this.rightNode = null;
            this.parentNode = null;
        }
        public BTNode(BTNode parent, int value)
        {
            this.parentNode = parent;
            this.value = value;
        }
    }
    public class BinaryTree
    {

        BTNode rootNode;
        private int size;

        public BinaryTree()
        {
            rootNode = null;
            this.size = 0;
        }

        public BinaryTree(BTNode rt)
        {
            this.rootNode = rt;
            this.size = 0;
        }

        public void Add(int value)
        {
            if (rootNode != null)
            {
                BTNode current = rootNode;
                bool added = false;
                while (!added)
                {
                    if (current.value == value)
                    {
                        added = !added;
                    }
                    else
                    {
                        if (current.value > value)
                        {
                            if (current.leftNode != null)
                            {
                                current = current.leftNode;
                            }
                            else
                            {
                                current.leftNode = new BTNode(current, value);
                                this.size++;
                                added = !added;
                            }
                        }
                        else
                        {
                            if (current.rightNode != null)
                            {
                                current = current.rightNode;
                            }
                            else
                            {
                                current.rightNode = new BTNode(current, value);
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
                rootNode = new BTNode(null, value);
            }
        }

        public void Init(int[] array)
        {
            this.Clear();
            foreach (var item in array) { this.Add(item); }
        }

        public void Clear()
        {
            rootNode = new BTNode();
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
            if (rootNode == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                return (BinaryTree.ToArray(rootNode)).ToArray();
            }
        }
        private static List<int> ToArray(BTNode tree)
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
        /// <param name="node">Current node</param>
        /// <returns>Side</returns>
        private Side? MeForParent(BTNode node)
        {
            if (node.parentNode == null) return null;
            if (node.parentNode.leftNode == node) return Side.Left;
            if (node.parentNode.rightNode == node) return Side.Right;
            return null;
        }
        private void Add(int value, BTNode node, BTNode parent)
        {

            if (node.value == value)
            {
                node.value = value;
                node.parentNode = parent;
                return;
            }
            if (node.value > value)
            {
                if (node.leftNode == null) node.leftNode = new BTNode();
                Add(value, node.leftNode, node);
            }
            else
            {
                if (node.rightNode == null) node.rightNode = new BTNode();
                Add(value, node.rightNode, node);
            }
        }
        private void Add(BTNode data, BTNode node, BTNode parent)
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
                if (node.leftNode == null) node.leftNode = new BTNode();
                Add(data, node.leftNode, node);
            }
            else
            {
                if (node.rightNode == null) node.rightNode = new BTNode();
                Add(data, node.rightNode, node);
            }
        }

        public void Delete(BTNode node)
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
            return CountElements(this.rootNode);
        }
        /// <summary>
        /// Tree counter
        /// </summary>
        /// <param name="node">Root node</param>
        /// <returns>count of elements in the tree</returns>
        private int CountElements(BTNode node)
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
        /// Find node with current value
        /// </summary>
        /// <param name="data">Value for search</param>
        /// <returns>Founded result</returns>
        public BTNode Find(int value)
        {
            BTNode current = rootNode;

            if (current.value == value) return current;
            if (current.value > value)
            {
                return Find(value, current.leftNode);
            }
            return Find(value, current.rightNode);
        }

        /// <summary>
        /// Find value in current node
        /// </summary>
        /// <param name="value">Value for search</param>
        /// <param name="node">Node for search</param>
        /// <returns>Founded result</returns>
        public BTNode Find(int value, BTNode node)
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
