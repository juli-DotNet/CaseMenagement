using System;
using System.Collections.Generic;
using System.Text;

namespace JTCM.Services
{
    public class BaseService
    {
        //protected Call HandleCall(Func<Call> method)
        //{
        //    try
        //    {
        //        return method();
        //    }
        //    catch (ApplicationException ex)
        //    {
        //        Logging.Logger.Error(ex);
        //        return new Call
        //        {
        //            IsSuccessful = false,
        //            Message = ex.Message,
        //            Exception = new ServiceException(ex)
        //        };
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        Logging.Logger.Error(ex);
        //        return new Call
        //        {
        //            IsSuccessful = false,
        //            Message = ex.Message,
        //            Exception = new ServiceException(ex)
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        Logging.Logger.Error(ex);
        //        return new Call
        //        {
        //            IsSuccessful = false,
        //            Message = Translation.Get("Ndodhi një problem në përpunimin e të dhënave. Ju lutem kontaktoni me administratorin!"),
        //            Exception = new ServiceException(ex.Message, ex.InnerException, ex.StackTrace)
        //        };
        //    }
        //}

        //protected Call<T> HandleCall<T>(Func<T> method)
        //{
        //    try
        //    {
        //        var result = method();
        //        return new Call<T> { Result = result, IsSuccessful = true };
        //    }
        //    catch (ApplicationException ex)
        //    {
        //        Logging.Logger.Error(ex);
        //        return new Call<T>
        //        {
        //            Result = default(T),
        //            IsSuccessful = false,
        //            Message = ex.Message,
        //            Exception = new ServiceException(ex)
        //        };
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        Logging.Logger.Error(ex);
        //        return new Call<T>
        //        {
        //            Result = default(T),
        //            IsSuccessful = false,
        //            Message = ex.Message,
        //            Exception = new ServiceException(ex)
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        Logging.Logger.Error(ex);
        //        return new Call<T>
        //        {
        //            Result = default(T),
        //            IsSuccessful = false,
        //            Message = Translation.Get("Ndodhi një problem në përpunimin e të dhënave. Ju lutem kontaktoni me administratorin!"),
        //            Exception = new ServiceException(ex.Message, ex.InnerException, ex.StackTrace)
        //        };
        //    }
        //}

        //protected Call<T> HandleCall<T>(Func<Call<T>> method)
        //{
        //    try
        //    {
        //        return method();
        //    }
        //    catch (ApplicationException ex)
        //    {
        //        Logging.Logger.Error(ex);
        //        return new Call<T>
        //        {
        //            Result = default(T),
        //            IsSuccessful = false,
        //            Message = ex.Message,
        //            Exception = new ServiceException(ex)
        //        };
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        Logging.Logger.Error(ex);
        //        return new Call<T>
        //        {
        //            Result = default(T),
        //            IsSuccessful = false,
        //            Message = ex.Message,
        //            Exception = new ServiceException(ex)
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        Logging.Logger.Error(ex);
        //        return new Call<T>
        //        {
        //            Result = default(T),
        //            IsSuccessful = false,
        //            Message = Translation.Get("Ndodhi një problem në përpunimin e të dhënave. Ju lutem kontaktoni me administratorin!"),
        //            Exception = new ServiceException(ex)
        //        };
        //    }
        //}
    }
}
