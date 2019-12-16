using System;
using System.Collections.Generic;

namespace KPIAvalicaoEquipeSuporte.Models.Atendimentos
{
    public class Atendimento
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string ExternalId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Type { get; set; }
        public string Subjetct { get; set; }
        public string RawSubject { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string Recipient { get; set; }
        public int RequesterId { get; set; }
        public int SubmitterId { get; set; }
        public int AssigneeId { get; set; }
        public int GroupId { get; set; }
        public IEnumerable<Colaborator> Colaborators { get; set; }
        public IEnumerable<Colaborator> Followers { get; set; }
        public IEnumerable<string> Emails { get; set; }
        public int ForumTopicId { get; set; }
        public int ProblemId { get; set; }
        public bool HasIncident { get; set; }
        public bool IsPublic { get; set; }
        public string DueAt { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public Dictionary<int,string> Via { get; set; }
        public Dictionary<int, string> CustomFields { get; set; }
        public SatisfactionRating SatisfactionRating { get; set; }
        public Dictionary<int,string> Fields { get; set; }
        public IEnumerable<int> SharingAgreementIds { get; set; }
        public IEnumerable<int> FollowUpIds { get; set; }
        public int TicketFormId { get; set; }   
        public int BrandId { get; set; }
        public decimal SatisfactionProbability { get; set; }
        public bool AllowChannelback { get; set; }
        public bool AllowAttachments { get; set; }
    }
}