﻿namespace StackoverflowDb.EFCore.Data
{
    public class PostComments
    {
        public int Id { get; set; }
        public int? OwnerUserId { get; set; }
        public string Body { get; set; }
        public string Text { get; set; }
        public int? Score { get; set; }
    }
}
