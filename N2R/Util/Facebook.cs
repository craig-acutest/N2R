using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Facebook;
using N2R.Models;
using Newtonsoft.Json.Linq;

namespace N2R.Util
{
    public class Facebook
    {
        public List<FbUser> GetFriends(string myAccessToken)
        {
            FacebookClient client = new FacebookClient(myAccessToken);

            var friendListData = client.Get("/me/friends");
            JObject friendListJson = JObject.Parse(friendListData.ToString());

            List<FbUser> fbUsers = new List<FbUser>();
            foreach (var friend in friendListJson["data"].Children())
            {
                FbUser fbUser = new FbUser();
                fbUser.Id = friend["id"].ToString().Replace("\"", "");
                fbUser.Name = friend["name"].ToString().Replace("\"", "");
                fbUsers.Add(fbUser);
            }

            return fbUsers;
        }
    }
}