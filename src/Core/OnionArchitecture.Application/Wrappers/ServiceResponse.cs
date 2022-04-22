namespace OnionArchitecture.Application.BaseModels
{
	public class ServiceResponse<T> : BaseResponse
	{
        public T Value { get; set; }

        public ServiceResponse(T value)
        {
            Value = value;
        }
    }
}

