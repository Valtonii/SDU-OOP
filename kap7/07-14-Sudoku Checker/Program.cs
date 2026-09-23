bool isValid = true;
int[,] solvedSudoku = {
    {8, 2, 7, 1, 5, 4, 3, 9, 6},
    {9, 6, 5, 3, 2, 7, 1, 4, 8},
    {3, 4, 1, 6, 8, 9, 7, 5, 2},
    {5, 9, 3, 4, 6, 8, 2, 7, 1},
    {4, 7, 2, 5, 1, 3, 6, 8, 9},
    {6, 1, 8, 9, 7, 2, 4, 3, 5},
    {7, 8, 6, 2, 3, 5, 9, 1, 4},
    {1, 5, 4, 7, 9, 6, 8, 2, 3},
    {2, 3, 9, 8, 4, 1, 5, 6, 7}
};

for (int i = 0; i < 9; i++) // Runs nine times, i = 0 to 8. Each pass handles one row and one column at the same time: pass 3 checks row 3 and column 3.
{
    bool[] found = new bool[9]; // Two fresh checklists, all false. found is for this pass's row. Declared inside the loop, so each pass gets new ones.
    bool[] foundCol = new bool[9]; // foundCol for this pass's column. Declared inside the loop, so each pass gets new ones.

    for (int col = 0; col < found.Length; col++)
    {
        found[solvedSudoku[i, col] - 1] = true;
    } // The row check. col runs 0 to 8. Line 20 reads cell [i, col]: row stays i, column moves. So the nine cells of row i, left to right. Each value ticks its box in found (value minus 1).

    for (int row = 0; row < foundCol.Length; row++)
    {
        foundCol[solvedSudoku[row, i] - 1] = true; // changed naming from col to row here because it walks down rows, so it doesnt make sense to call it col.
    } // The column check. col runs 0 to 8 again. Line 25 reads cell [row, i]: row moves, column stays i. So the nine cells of column i, top to bottom. Ticks into foundcol.

    for (int check = 0; check < found.Length; check++)
    {
        if (found[check] == false)
        {
            isValid = false;
        }
    } // Inspect found. If any slot is still false, some number never appeared in row i, so isValid becomes false. One false slot is enough.

    for (int check = 0; check < foundCol.Length; check++)
    {
        if (foundCol[check] == false)
        {
            isValid = false;
        } // Same inspection for foundcol, for column i.
    }
}

for (int blockRow = 0; blockRow <= 6; blockRow += 3)
{ // Makes a loop for every 3x3 group on the rows
    for (int blockCol = 0; blockCol <= 6; blockCol += 3)
    { // Makes a loop for every 3x3 group on the columns
        bool[] foundBlock = new bool[9]; // For this pass's block.

        for (int row = 0; row < 3; row++)
        { // the rows in a 3x3
            for (int col = 0; col < 3; col++)
            { // the columns in a 3x3

                foundBlock[solvedSudoku[blockRow + row, blockCol + col] - 1] = true; /* row and col are 0, 1, 2. They are not grid positions.
                They are steps away from the block's corner. So:

                grid row = blockRow + row, fx the block starting at [3,3] means the rows that need to be checked are 3 + 0, 3 + 1 and 3 + 2
                grid column = blockCol + col, same logic applies
                */
            }
        }

        for (int checkBlock = 0; checkBlock < foundBlock.Length; checkBlock++)
        {
            if (foundBlock[checkBlock] == false)
            {
                isValid = false;
            }
        } // Inspect found. If any slot is still false, some number never appeared in the block, so isValid becomes false. One false slot is enough.
    }
}
if (isValid == false)
{
    Console.WriteLine("Incorrect solution!");
}
else
{
    Console.WriteLine("Correct solution!");
} // After the loop. isValid is true only if all nine rows, all nine columns and all nine blocks passed. The final if prints one verdict.
