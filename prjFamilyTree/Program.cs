namespace prjFamilyTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<string> royalTree = new Tree<string>();
            royalTree.Root = new TreeNode<string> { Data = "King Charles III" };

            // Children of King Charles III
            var william = new TreeNode<string> { Data = "William, Prince of Wales", Parent = royalTree.Root };
            var harry = new TreeNode<string> { Data = "Harry, Duke of Sussex", Parent = royalTree.Root };
            var anne = new TreeNode<string> { Data = "Anne, Princess Royal", Parent = royalTree.Root };
            var andrew = new TreeNode<string> { Data = "Andrew, Duke of York", Parent = royalTree.Root };
            var edward = new TreeNode<string> { Data = "Edward, Duke of Edinburgh", Parent = royalTree.Root };

            royalTree.Root.Children.AddRange(new[] { william, harry, anne, andrew, edward });

            // William's children
            var george = new TreeNode<string> { Data = "Prince George of Wales", Parent = william };
            var charlotte = new TreeNode<string> { Data = "Princess Charlotte of Wales", Parent = william };
            var louis = new TreeNode<string> { Data = "Prince Louis of Wales", Parent = william };
            william.Children.AddRange(new[] { george, charlotte, louis });

            // Harry's children
            var archie = new TreeNode<string> { Data = "Prince Archie of Sussex", Parent = harry };
            var lilibet = new TreeNode<string> { Data = "Princess Lilibet of Sussex", Parent = harry };
            harry.Children.AddRange(new[] { archie, lilibet });

            // Anne’s children
            var peter = new TreeNode<string> { Data = "Peter Phillips", Parent = anne };
            var zara = new TreeNode<string> { Data = "Zara Tindall", Parent = anne };
            anne.Children.AddRange(new[] { peter, zara });

            // Peter Phillips’ children
            var savannah = new TreeNode<string> { Data = "Savannah Phillips", Parent = peter };
            var isla = new TreeNode<string> { Data = "Isla Phillips", Parent = peter };
            peter.Children.AddRange(new[] { savannah, isla });

            // Zara Tindall’s children
            var mia = new TreeNode<string> { Data = "Mia Tindall", Parent = zara };
            var lena = new TreeNode<string> { Data = "Lena Tindall", Parent = zara };
            var lucas = new TreeNode<string> { Data = "Lucas Tindall", Parent = zara };
            zara.Children.AddRange(new[] { mia, lena, lucas });

            // Andrew’s children
            var beatrice = new TreeNode<string> { Data = "Princess Beatrice", Parent = andrew };
            var eugenie = new TreeNode<string> { Data = "Princess Eugenie", Parent = andrew };
            andrew.Children.AddRange(new[] { beatrice, eugenie });

            // Beatrice’s child
            var sienna = new TreeNode<string> { Data = "Sienna Mapelli Mozzi", Parent = beatrice };
            beatrice.Children.Add(sienna);

            // Eugenie’s children
            var august = new TreeNode<string> { Data = "August Brooksbank", Parent = eugenie };
            var ernest = new TreeNode<string> { Data = "Ernest Brooksbank", Parent = eugenie };
            eugenie.Children.AddRange(new[] { august, ernest });

            // Edward’s children
            var louise = new TreeNode<string> { Data = "Lady Louise Windsor", Parent = edward };
            var james = new TreeNode<string> { Data = "James, Earl of Wessex", Parent = edward };
            edward.Children.AddRange(new[] { louise, james });

            // ----------- OUTPUT -------------
            Console.WriteLine("-------- Royal Family Tree ---------");
            royalTree.PrintTree(royalTree.Root);

            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------ BFS ------------------");
            List<string> bfsResult = royalTree.BreadthFirstSearch();
            Console.WriteLine(string.Join(" -> ", bfsResult));
            Console.WriteLine();

            Console.WriteLine("------------ DFS ------------------");
            List<string> dfsResult = royalTree.DepthFirstSearch();
            Console.WriteLine(string.Join(" -> ", dfsResult));
            Console.WriteLine();

        }
    }
}