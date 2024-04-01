namespace AnonymousInformant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());

            while (testCases-- > 0)
            {
                var nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var n = nk[0];
                var k = nk[1];
                var b = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var canAnonymousInformantWordsBeTrue = true;
                var lastIndex = n - 1;

                k = Math.Min(k, n);

                for (var i = 0; i < k; i++)
                {
                    var rightShiftsToDo = b[lastIndex];

                    if (rightShiftsToDo > n)
                    {
                        canAnonymousInformantWordsBeTrue = false;
                        break;
                    }

                    lastIndex = (lastIndex + n - rightShiftsToDo) % n;
                }

                Console.WriteLine(canAnonymousInformantWordsBeTrue ? "Yes" : "No");
            }
        }
    }
}
