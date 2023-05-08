var line1 = new String[9] { "?", "?", "?", "?", "?", "?", "?", "?", "?" };
var line2 = new String[9] { "?", "?", "?", "?", "?", "?", "?", "?", "?" };
var line3 = new String[9] { "?", "?", "?", "?", "?", "?", "?", "?", "?" };
var line4 = new String[9] { "?", "?", "?", "?", "?", "?", "?", "?", "?" };
var line5 = new String[9] { "?", "?", "?", "?", "?", "?", "?", "?", "?" };
var line6 = new String[9] { "?", "?", "?", "?", "?", "?", "?", "?", "?" };
var line7 = new String[9] { "?", "?", "?", "?", "?", "?", "?", "?", "?" };
var line8 = new String[9] { "?", "?", "?", "?", "?", "?", "?", "?", "?" };
var line9 = new String[9] { "?", "?", "?", "?", "?", "?", "?", "?", "?" };
var puzzle = new String[][] { line1, line2, line3, line4, line5, line6, line7, line8, line9 };

void PrintSudoku(String[][] SudokuPuzzle)
{
    for (int i = 0; i < SudokuPuzzle.Length; i++)
    {

        for (int j = 0; j < SudokuPuzzle[i].Length; j++)
        {
            String character = SudokuPuzzle[i][j];

            Console.Write(character);
            if (j != SudokuPuzzle[i].Length - 1)
            {
                Console.Write(" | ");
            }

        }

        if (i != SudokuPuzzle.Length - 1)
        {
            Console.WriteLine();
            Console.WriteLine("-   -   -   -   -   -   -   -   -");
        }

        Console.WriteLine();
    }
}

PrintSudoku(puzzle);