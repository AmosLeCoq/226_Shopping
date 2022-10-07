﻿namespace Shopping
{
    public class Checkout : ICollectionOfArticles
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();
        private float _balance = 0f;
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            _articles.AddRange(articles);
            _balance++;
        }

        public List<Article> Remove(Boolean empty = false)
        {
            List<Article> articlesReadyToCheckout = new List<Article>();
            if (empty == true)
            {
                articlesReadyToCheckout.AddRange(_articles);
                _articles.Clear();
            }
            else
            {
                articlesReadyToCheckout.Add(_articles.Last());
                _articles.Remove(_articles.Last());
            }
            return articlesReadyToCheckout;
        }

        public List<Article> Articles
        {
            get
            {
                return _articles;
            }
        }

        public float Balance
        {
            get
            {
                return _balance;
            }
        }
        #endregion public methods

        #region private methods
        private void UpdateBalance()
        {
            {
                throw new NotImplementedException();
            }
        }
        #endregion private methods
    }
}
