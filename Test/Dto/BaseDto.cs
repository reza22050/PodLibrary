using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Dto
{
    public class BaseDto<T>
    {
        public BaseDto(bool IsSuccess, List<string> Message, T Data)
        {
            this.Data = Data;
            this.Message = Message;
            this.IsSuccess = IsSuccess;
        }

        public T Data { get; private set; }
        public List<string> Message { get; private set; }
        public bool IsSuccess { get; private set; }
    }

    public class BaseDto
    {
        public BaseDto(bool IsSuccess, List<string> Message)
        {
            this.Message = Message;
            this.IsSuccess = IsSuccess;
        }
        public List<string> Message { get; private set; }
        public bool IsSuccess { get; private set; }
    }
}
