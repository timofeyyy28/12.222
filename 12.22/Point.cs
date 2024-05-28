﻿
using ClassLibraryLabor10;

namespace _12._22
{
    internal class Point<T> where T : IInit, ICloneable, new()
    {
        public T Data { get; set; }
        public Point<T>? Next { get; set; }
        public Point<T>? Pred { get; set; }
        public static Point<T> MakeRandomData()
        {
            T data = new T();
            data.RandomInit();
            return new Point<T>(data);
        }
        public static T MakeRandomItem()
        {
            T data = new T();
            data.RandomInit();
            return data;
        }
        public Point()
        {
            this.Data = default(T);
            this.Next = null;
            this.Pred = null;
        }
        public Point(T data)
        {
            this.Data = data;
            this.Next = null;
            this.Pred = null;
        }
        public override string ToString()
        {
            return Data == null ? "" : Data.ToString();
        }
    }
}
