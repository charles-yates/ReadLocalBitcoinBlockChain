using System;
using BitcoinBlockchainParser; // Highly efficient file parser

class Program
{
    static void Main()
    {
        string pathToBlocks = @"C:\Users\YourUser\AppData\Roaming\Bitcoin\blocks";
        
        // Initialize parser targeting your local .dat files
        var parser = new BlockchainParser(pathToBlocks);

        // Enumerate over blocks sequentially
        foreach (var block in parser.ParseOrdered())
        {
            Console.WriteLine($"Parsing Block: {block.Height} | Hash: {block.Hash}");
            
            foreach (var tx in block.Transactions)
            {
                Console.WriteLine($"  Transaction: {tx.Hash}");
            }
        }
    }
}
