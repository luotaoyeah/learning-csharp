using System;

namespace P50;

public class Book
{
    /// <summary>
    /// long/int/short 类型的主键, 默认使用自增策略.
    /// </summary>
    public long Id { get; set; }

    public string Title { get; set; }
    public DateTime PubTime { get; set; }
    public double Price { get; set; }
}
