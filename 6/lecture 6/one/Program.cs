string text = "(1,2) (2,3) (4,5) (6,7)"
            .Replace("(", "")
            .Replace(")", "");


Console.WriteLine(text);
var data = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // for split 4 elements into two more (further x, y) and convert each of them into a number
                // Where(e => e.x % 2 == 0) // proviso for using next string only for items with even "x"
                // .Select(point => (point.x * 10, point.y)) // for print (10,2) (20,3) (40,5) (60,7). With previous "where" it will be without the 1st coordinates (1,2).
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]); // in such case rn will be printed (1,2) (2,3) (4,5) (6,7). if (data[i].x*10), so it will be 10 20 40 60 (without "y" one).
    // 4 strings below is for print data[] before select with parses (str №9)
    // for (int k = 0; k < data[i].Length; k++)
    // {
    //     Console.WriteLine(data[i][k]);
    // }    
    //Console.WriteLine();
}