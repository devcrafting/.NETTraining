﻿using System.Collections.Generic;
using System.Linq;
using Messaging.Domain;

namespace Messaging.Infrastructure
{
    public class TimelineMessageRepository : ITimelineMessageRepository
    {
        private readonly IEnumerable<TimelineMessage> _initialElements;

        public TimelineMessageRepository()
        {
            _initialElements = new List<TimelineMessage>();
        }

        public TimelineMessageRepository(IEnumerable<TimelineMessage> initialElements)
        {
            _initialElements = initialElements;
        }

        public IEnumerable<TimelineMessage> GetLastMessagesForUser(UserId userId, int i)
        {
            return _initialElements
                .Where(x => x.OwnerId.Equals(userId))
                .OrderByDescending(x => x.PublishDate)
                .Take(i);
        }

        public void Save(TimelineMessage timelineMessage)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TimelineMessage> GetById(MessageId messageId)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(TimelineMessage timelineMessage)
        {
            throw new System.NotImplementedException();
        }
    }
}