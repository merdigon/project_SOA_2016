﻿using Client.HelpingForm;
using Client.Models;
using Client.ProcessObjects;
using Client.ResourceForms.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.ResourceForms
{
    public partial class ReviewForm : BaseForm
    {
        List<Review> dataList;
        Movie currentMovie;
        ProcessObject processObject;
        public ReviewForm(List<Review> listOfReviews, Movie movie, ProcessObject processObject)
        {
            InitializeComponent();
            dataList = listOfReviews;
            dataList.ForEach(p => p.User = processObject.UserClient.GetUser(p.UserID));
            currentMovie = movie;
            this.processObject = processObject;
            FillForm();
        }

        private void FillForm()
        {
            foreach(Review review in dataList){
                OneReviewControl control = new OneReviewControl(review);
                flowLayoutPanel1.Controls.Add(control);
            }

            this.btnCommit_ChangeName("Add");
            this.btnCommit_ChangeImage(Properties.Resources.add_icon);

            cbNode.DataSource = new int[] { 0, 1, 2, 3, 4, 5 };
                       
        }

        public override void CommitClick()
        {
            Review newReview = new Review()
            {
                Content = tbContent.Text,
                Movie = currentMovie,
                User = processObject.LoggedUser,
                Note = (int)cbNode.SelectedItem,
                UserID = processObject.LoggedUser.Id,
                Date = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString()
            };
            processObject.ReviewClient.AddReview(newReview);
            RefreshData();
        }

        public void RefreshData()
        {
            dataList = processObject.ReviewClient.GetReviewsForMovie(currentMovie.Id);
            dataList.ForEach(p => p.User = (p.UserID != 0 ? processObject.UserClient.GetUser(p.UserID): null));
            flowLayoutPanel1.Controls.Clear();
            foreach (Review review in dataList)
            {
                OneReviewControl control = new OneReviewControl(review);
                flowLayoutPanel1.Controls.Add(control);
            }
            flowLayoutPanel1.Refresh();
        }
    }
}
