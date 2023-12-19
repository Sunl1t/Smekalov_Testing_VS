using System;

class Test
{
    public void InputFirstSymbol_InputValidSymbol_ReturnsValidChar()
    {
        // Arrange
        var expected = 'A';
        var input = new StringReader("A");
        Console.SetIn(input);

        // Act
        Program.InputFirstSymbol();
        var actual = Program.ch1;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    
    public void InputSecondSymbol_InputValidSymbol_ReturnsValidChar()
    {
        // Arrange
        var expected = 'B';
        var input = new StringReader("B");
        Console.SetIn(input);

        // Act
        Program.InputSecondSymbol();
        var actual = Program.ch2;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    
    public void InputFirstSymbol_InputInvalidSymbol_ReturnsWhitespaceChar()
    {
        // Arrange
        var expected = ' ';
        var input = new StringReader("123");
        Console.SetIn(input);

        // Act
        Program.InputFirstSymbol();
        var actual = Program.ch1;

        // Assert
        Assert.AreEqual(expected, actual);
    }



    
    public void PrintSymbolsAndAsciiCodes_BothSymbolsSet_OutputCorrectMessage()
    {
        // Arrange
        var expectedOutput = "Ñèìâîë A èìååò êîä ASCII 65\r\nÑèìâîë B èìååò êîä ASCII 66\r\n";
        var output = new StringWriter();
        Console.SetOut(output);

        Program.ch1 = 'A';
        Program.ch2 = 'B';

        // Act
        Program.PrintSymbolsAndAsciiCodes();
        var actualOutput = output.ToString();

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    
    public void PrintSumOfAsciiCodes_BothSymbolsSet_OutputCorrectMessage()
    {
        // Arrange
        var expectedOutput = "Ñóììà êîäîâ ASCII ñèìâîëîâ A è B ðàâíà 131\r\n";
        var output = new StringWriter();
        Console.SetOut(output);

        Program.ch1 = 'A';
        Program.ch2 = 'B';

        // Act
        Program.PrintSumOfAsciiCodes();
        var actualOutput = output.ToString();

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }
}
