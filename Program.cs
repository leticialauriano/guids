using System;

namespace Guids
{

    class Program
    {
        private static void Main(string[] args)
        {
            var id = Guid.NewGuid(); //gerar ele
            id.ToString();

            id = new Guid("número gerado");
            if (id == Guid.NewGuid()) //comparação

            Console.WriteLine(id.ToString().Substring(0,8));

        }
    }

}
