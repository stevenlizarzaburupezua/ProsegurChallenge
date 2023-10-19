using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.DTO
{
    public static class ResponseExtension
    {
        public static ResponseDTO<T> ToResponse<T>(this T obj)
        {
            return ResponseDTO<T>.Single(obj);
        }

        public static ResponseDTO<T> ToResponse<T>(this List<T> list)
        {
            return ResponseDTO<T>.List(list);
        }

        public static ResponseDTO<T> ToResponse<T>(this IEnumerable<T> list)
        {
            return ResponseDTO<T>.List(list.ToList());
        }

        public static ResponseDTO<TransactionResponse> Success(this TransactionResponse transactionResponse)
        {
            transactionResponse.Success = true;
            transactionResponse.Codigo = "TEST";
            transactionResponse.Mensaje = "TEST";

            return ResponseDTO<TransactionResponse>.Single(transactionResponse);
        }
    }
}
