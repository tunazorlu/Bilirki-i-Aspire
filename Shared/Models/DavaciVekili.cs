﻿namespace BilirkisiAspire.Shared.Models
{
    public class DavaciVekili
    {
        public int DavaciVekiliId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public int MahkemeDosyasiId { get; set; }
        public virtual MahkemeDosyasi? MahkemeDosyasi { get; set; }
    }
}
