using System;
using System.ComponentModel.DataAnnotations;        // 参照を追加。
using System.ComponentModel.DataAnnotations.Schema; // 参照を追加。

namespace Data.Database
{
    [Table("testdb")] // テーブルの名前を入力。
    // [Table("table_info", schema = "name")] // スキーマをここで設定する事も可能。
    public class Hoge
    {
        [Key] // 主キーを設定。
        [Column("id")] // データベース上のカラム名を入力。
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("kana")]
        public string Kana { get; set; }

        [Column("data")]
        public DateTime Data { get; set; }
    }
}