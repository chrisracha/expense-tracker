﻿namespace ExpenseTrackerApp.Data
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public bool IsIncome { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public string? UserId { get; set; }

    }
}
