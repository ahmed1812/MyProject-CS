﻿using MyProjet.Models;
using System.Collections.Generic;

namespace MyProjet.Data
{
    public interface IReviewRepository
    {
        public IEnumerable<Review> GetAllReview();
        public Review GetReview(int id);
        public void UpdateReview(Review review);
    }
}