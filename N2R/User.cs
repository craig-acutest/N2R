//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace N2R
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Conversations = new HashSet<Conversation>();
            this.Conversations1 = new HashSet<Conversation>();
            this.ConversationReplies = new HashSet<ConversationReply>();
            this.FavoriteVenues = new HashSet<FavoriteVenue>();
            this.GroupInvitations = new HashSet<GroupInvitation>();
            this.GroupInvitations1 = new HashSet<GroupInvitation>();
            this.GroupUsers = new HashSet<GroupUser>();
            this.Logs = new HashSet<Log>();
            this.UserAddresses = new HashSet<UserAddress>();
            this.UserDetails = new HashSet<UserDetail>();
            this.UserFriends = new HashSet<UserFriend>();
            this.UserFriends1 = new HashSet<UserFriend>();
            this.UserLocations = new HashSet<UserLocation>();
            this.UserMusicGenres = new HashSet<UserMusicGenre>();
            this.UserStatus = new HashSet<UserStatu>();
            this.VenueFeedbacks = new HashSet<VenueFeedback>();
            this.VenueInvitations = new HashSet<VenueInvitation>();
            this.VenueInvitations1 = new HashSet<VenueInvitation>();
            this.VenueVisits = new HashSet<VenueVisit>();
            this.BusinessUsers = new HashSet<BusinessUser>();
            this.UserEntertainers = new HashSet<UserEntertainer>();
            this.Orders = new HashSet<Order>();
            this.UserGalleries = new HashSet<UserGallery>();
        }
    
        public int ID { get; set; }
        public string ASPUser { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual ICollection<Conversation> Conversations { get; set; }
        public virtual ICollection<Conversation> Conversations1 { get; set; }
        public virtual ICollection<ConversationReply> ConversationReplies { get; set; }
        public virtual ICollection<FavoriteVenue> FavoriteVenues { get; set; }
        public virtual ICollection<GroupInvitation> GroupInvitations { get; set; }
        public virtual ICollection<GroupInvitation> GroupInvitations1 { get; set; }
        public virtual ICollection<GroupUser> GroupUsers { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
        public virtual ICollection<UserDetail> UserDetails { get; set; }
        public virtual ICollection<UserFriend> UserFriends { get; set; }
        public virtual ICollection<UserFriend> UserFriends1 { get; set; }
        public virtual ICollection<UserLocation> UserLocations { get; set; }
        public virtual ICollection<UserMusicGenre> UserMusicGenres { get; set; }
        public virtual ICollection<UserStatu> UserStatus { get; set; }
        public virtual ICollection<VenueFeedback> VenueFeedbacks { get; set; }
        public virtual ICollection<VenueInvitation> VenueInvitations { get; set; }
        public virtual ICollection<VenueInvitation> VenueInvitations1 { get; set; }
        public virtual ICollection<VenueVisit> VenueVisits { get; set; }
        public virtual ICollection<BusinessUser> BusinessUsers { get; set; }
        public virtual ICollection<UserEntertainer> UserEntertainers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<UserGallery> UserGalleries { get; set; }
    }
}