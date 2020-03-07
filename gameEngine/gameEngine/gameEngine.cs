using System;
using algo_data_structures;

namespace gameEngine
{
    class validationRules
    {
        
        public static bool isBiggerThanLength (int Value, int ToCompareValue)
        {
            if (Value >= ToCompareValue) return true;

            return false;
        } 
    }

    class SetUpEnvironment
    {

        public static void InitialiseMatrix(ref matrixType<char> matrixObject)
        {
             char initialisor = '0';

            matrixObject = new matrixType<char>
            {
                Line = 3,
                Column = 3
            };

            for (int iterator = matrixObject.StartLinePoint; iterator < matrixObject.Line; iterator++)
                for (int jiterator = matrixObject.StartColumnPoint; jiterator < matrixObject.Column; jiterator++)
                    matrixObject.matrix[iterator, jiterator] = initialisor;
        }

        public static void PutsMatrix(ref matrixType<char> matrixObject)
        {

            for (int iterator = matrixObject.StartLinePoint; iterator < matrixObject.Line; iterator++)
            {
                for (int jiterator = matrixObject.StartColumnPoint; jiterator < matrixObject.Column; jiterator++)
                    Console.Write(matrixObject.matrix[iterator, jiterator] + "\t");

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static void MatrixItemInitialisation(ref matrixType<char> matrixObject, char Value, limits<int> position)
        {

            if (validationRules.isBiggerThanLength(position.minimLimit, matrixObject.Line)) throw new System.ArgumentException("Cannot handle position bigger than line", "position.minimLimit");
            if (validationRules.isBiggerThanLength(position.maximLimit, matrixObject.Line)) throw new System.ArgumentException("Cannot handle position bigger than line", "position.maximLimit");
            if (validationRules.isBiggerThanLength(position.minimLimit, matrixObject.Column)) throw new System.ArgumentException("Cannot handle position bigger than column", "position.minimLimit");
            if (validationRules.isBiggerThanLength(position.maximLimit, matrixObject.Column)) throw new System.ArgumentException("Cannot handle position bigger than column", "position.maximLimit");

            if (matrixObject.matrix[position.minimLimit, position.maximLimit] != '0') throw new System.ArgumentException("Cannot assign an already assigned position on board", "matrixObject.matrix[position.minimLimit, position.maximLimit]");

            matrixObject.matrix[position.minimLimit, position.maximLimit] = Value;
        }
    }

    class GameEngine
    {
        private SetUpEnvironment setup = new SetUpEnvironment();
        

    }

    class Program
    {
        static void Main(string[] args)
        {
            matrixType<char> GameBoard = new matrixType<char>();

            SetUpEnvironment.InitialiseMatrix(ref GameBoard);
            SetUpEnvironment.PutsMatrix(ref GameBoard);
        }
    }
}
