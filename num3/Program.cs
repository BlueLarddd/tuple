int[] nums = new int[] {-1,-2,-3};
var comb = from a in nums
           from b in nums
           from c in nums
           where a != b && a != c && b != c 
           select Tuple.Create(a, b, c);
foreach (Tuple<int, int, int> t in comb)
{
    Console.WriteLine("{0}, {1}, {2}", t.Item1, t.Item2, t.Item3);
}
var comb2 = from a in nums
           from b in nums
           from c in nums
           where a == b && a == c && b == c
           select Tuple.Create(a, b, c);
foreach (Tuple<int, int, int> t in comb2)
{
    Console.WriteLine("{0}, {1}, {2}", t.Item1, t.Item2, t.Item3);
}
var comb3 = from a in nums
            from b in nums
            from c in nums
            where a == b && a != c && b != c
            select Tuple.Create(a, b, c);
foreach (Tuple<int, int, int> t in comb3) //tuple - кортеж для группировки нескольких элементов данных в упрощенную структуру, в нем объявляем типы переменных. foreach это же оператор, обеспечивающий передвижение(итерации) по элементам массиву
{
    Console.WriteLine("{0}, {1}, {2}", t.Item1, t.Item2, t.Item3); //тут объявляем имена полей для переменных
}
var comb4 = from a in nums
            from b in nums
            from c in nums
            where a == c && a != b && b != c
            select Tuple.Create(a, b, c);
foreach (Tuple<int, int, int> t in comb4)
{
    Console.WriteLine("{0}, {1}, {2}", t.Item1, t.Item2, t.Item3);
}
var comb5 = from a in nums
            from b in nums
            from c in nums
            where c == b && a != b && a != c
            select Tuple.Create(a, b, c);
foreach (Tuple<int, int, int> t in comb5)
{
    Console.WriteLine("{0}, {1}, {2}", t.Item1, t.Item2, t.Item3);
}