using System;
using System.Net;
using NBitcoin;
using NBitcoin.RPC;

class Program
{
    static void Main()
    {
        // 1. Set up network and credentials
        Network network = Network.Main;
        NetworkCredential credentials = new NetworkCredential("your_rpc_user", "your_rpc_password");
        
        // 2. Connect to your local Bitcoin Core Node
        RPCClient rpcClient = new RPCClient(credentials, "localhost:8332", network);

        // 3. Read blockchain details
        var blockchainInfo = rpcClient.GetBlockchainInfo();
        Console.WriteLine($"Current Block Height: {blockchainInfo.Blocks}");
        
        // 4. Fetch a specific block header
        BlockHeader header = rpcClient.GetBlockHeader(blockchainInfo.Blocks);
        Console.WriteLine($"Latest Block Hash: {header.GetHash()}");
    }
}
