﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueue
{
    internal class Node
    {
        public int data;
        public Node next;
        public Node(int d) 
        {
            data = d;
            next = null;
        }
    }
}
