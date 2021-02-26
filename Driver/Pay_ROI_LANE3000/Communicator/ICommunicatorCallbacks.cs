namespace PAY_ROI_LANE3000.Communicator
{
    public interface ICommunicatorCallbacks
    {
        void InitRequest(object parameters);

        void TestRequest(object parameters);

        void PayRequest(object parameters);
    }
}
