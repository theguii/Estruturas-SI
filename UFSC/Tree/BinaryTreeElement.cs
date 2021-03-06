﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree {
    class BinaryTreeElement<T> where T : IComparable {

        public BinaryTreeElement<T> Parent { get; set; }
        public BinaryTreeElement<T> Left { get; set; }
        public BinaryTreeElement<T> Right { get; set; }

        public int Height { get; set; }

        public BinaryTreeElement(T value) {
            Value = value;
            Height = 1;
        }

        public T Value { get; set; }



    }
}
