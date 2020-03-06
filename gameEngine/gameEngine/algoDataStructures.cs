namespace algo_data_structures
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

        public oneDimensionalArrayType <Type> mainDiagonal = new oneDimensionalArrayType<Type>();
        public oneDimensionalArrayType <Type> aboveMainDiagonal = new oneDimensionalArrayType<Type>();
        public oneDimensionalArrayType <Type> underMainDiagonal = new oneDimensionalArrayType<Type>();
        public oneDimensionalArrayType <Type> secondaryDiagonal = new oneDimensionalArrayType<Type>();
        public oneDimensionalArrayType <Type> aboveSecondaryDiagonal = new oneDimensionalArrayType<Type>();
        public oneDimensionalArrayType <Type> underSecondaryDiagonal = new oneDimensionalArrayType<Type>();
        public oneDimensionalArrayType <Type> northElements = new oneDimensionalArrayType<Type>();
        public oneDimensionalArrayType <Type> southElements = new oneDimensionalArrayType<Type>();
        public oneDimensionalArrayType <Type> eastElements = new oneDimensionalArrayType<Type>();
        public oneDimensionalArrayType <Type> westElements = new oneDimensionalArrayType<Type>();

        public Type[,] matrix = new Type [generalSizes.MATRIX_STD_LENGTH, generalSizes.MATRIX_STD_LENGTH];
    }

    class binaryTreeType <Type>
    {
        public Type value;
        public  binaryTreeType <Type> leftLeaf = new binaryTreeType<Type>();
        public binaryTreeType <Type> rightLeaf = new binaryTreeType<Type>();
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

        public matrixType <Type> adjacencyMatrix = new matrixType<Type>();
        public oneDimensionalArrayType <Type> verticesValency = new oneDimensionalArrayType<Type>();
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

        limits<float> roots = new limits<float>();
    }

    class complexNumber
    {
        private const float StandardComplexNumber = 1;

        public float ComplexNumberLength = StandardComplexNumber;
        public float RealPart = StandardComplexNumber;
        public float ImaginaryPaty = StandardComplexNumber;
    }
}
