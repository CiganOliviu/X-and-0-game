/*
MIT License

Copyright (c) 2020 Cigan Oliviu David

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

*/

﻿namespace algo_data_structures
{

    class generalSizes
    {
        public const int zeroSize = 0;
        public const int MATRIX_STD_LENGTH = 100;
        public const int STD_LENGTH = 10000;
    }

    class oneDimensionalArrayType <Type>
    {

        public int Length = generalSizes.zeroSize;
        public int StartPoint = generalSizes.zeroSize;
        public int EndPoint = generalSizes.zeroSize;

        public Type[] oneDimensionalArray = new Type [generalSizes.STD_LENGTH];
    }

    class matrixType <Type>
    {
        public int Line = generalSizes.zeroSize;
        public int Column = generalSizes.zeroSize;

        public int StartLinePoint = generalSizes.zeroSize;
        public int EndLinePoint = generalSizes.zeroSize;
        public int StartColumnPoint = generalSizes.zeroSize;
        public int EndColumnPoint = generalSizes.zeroSize;

        public oneDimensionalArrayType <Type> mainDiagonal;
        public oneDimensionalArrayType <Type> aboveMainDiagonal;
        public oneDimensionalArrayType <Type> underMainDiagonal;
        public oneDimensionalArrayType <Type> secondaryDiagonal;
        public oneDimensionalArrayType <Type> aboveSecondaryDiagonal;
        public oneDimensionalArrayType <Type> underSecondaryDiagonal;
        public oneDimensionalArrayType <Type> northElements;
        public oneDimensionalArrayType <Type> southElements;
        public oneDimensionalArrayType <Type> eastElements;
        public oneDimensionalArrayType <Type> westElements;

        public Type[][] matrix = new Type [generalSizes.MATRIX_STD_LENGTH][];
    }

    class binaryTreeType <Type>
    {
        public Type value;
        public  binaryTreeType <Type> leftLeaf;
        public binaryTreeType <Type> rightLeaf;
    }

    class graphType <Type>
    {
        public graphType ()
        {
            adjacencyMatrix.Line = vertices;
            adjacencyMatrix.Column = adjacencyMatrix.Line;
            adjacencyMatrix.StartLinePoint = adjacencyMatrix.StartColumnPoint;
            adjacencyMatrix.EndLinePoint = adjacencyMatrix.EndColumnPoint;
        }

        public int vertices = generalSizes.zeroSize;
        public int edges = generalSizes.zeroSize;

        public matrixType <Type> adjacencyMatrix;
        public oneDimensionalArrayType <Type> verticesValency;
    }

    class limits <Type>
    {
        public Type minimLimit;
        public Type maximLimit;
    }

    class linearEquation
    {
        public float slope;
        public float y_intercept;
        public float root;
    }

    class quadraticEquation
    {
        public float coefficient_a;
        public float coefficient_b;
        public float coefficient_c;

        limits<float> roots;
    }

    class complexNumber
    {
        private const float StandardComplexNumber = 1;

        public float ComplexNumberLength = StandardComplexNumber;
        public float RealPart = StandardComplexNumber;
        public float ImaginaryPaty = StandardComplexNumber;
    }
}
