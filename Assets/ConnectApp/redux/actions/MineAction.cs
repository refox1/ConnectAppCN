using System.Collections.Generic;
using ConnectApp.models;

namespace ConnectApp.redux.actions {
    public class FetchMyFutureEventsAction : RequestAction {
        public int pageNumber = 0;
    }

    public class FetchMyFutureEventsSuccessAction : BaseAction {
        public List<IEvent> events;
    }

    public class FetchMyPastEventsAction : RequestAction {
        public int pageNumber = 0;
    }

    public class FetchMyPastEventsSuccessAction : BaseAction {
        public List<IEvent> events;
    }
}