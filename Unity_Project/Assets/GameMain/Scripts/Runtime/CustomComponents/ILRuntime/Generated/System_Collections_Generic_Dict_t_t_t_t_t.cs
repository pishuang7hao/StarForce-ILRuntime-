using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class System_Collections_Generic_Dictionary_2_KeyValuePair_2_Byte_Int32_Byte_Array_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>, System.Byte[]>);
            args = new Type[]{typeof(System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>), typeof(System.Byte[]).MakeByRefType()};
            method = type.GetMethod("TryGetValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetValue_0);
            args = new Type[]{typeof(System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>)};
            method = type.GetMethod("ContainsKey", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ContainsKey_1);
            args = new Type[]{typeof(System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>), typeof(System.Byte[])};
            method = type.GetMethod("set_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Item_2);
            args = new Type[]{typeof(System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>), typeof(System.Byte[])};
            method = type.GetMethod("Add", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Add_3);


        }


        static StackObject* TryGetValue_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Byte[] @value = (System.Byte[])typeof(System.Byte[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.KeyValuePair<System.Byte, System.Int32> @key = (System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>)typeof(System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>, System.Byte[]> instance_of_this_method = (System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>, System.Byte[]>)typeof(System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>, System.Byte[]>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryGetValue(@key, out @value);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = value;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = value;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, value);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = value;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, value);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Byte[][];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = value;
                    }
                    break;
            }

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* ContainsKey_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.KeyValuePair<System.Byte, System.Int32> @key = (System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>)typeof(System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>, System.Byte[]> instance_of_this_method = (System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>, System.Byte[]>)typeof(System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>, System.Byte[]>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ContainsKey(@key);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_Item_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Byte[] @value = (System.Byte[])typeof(System.Byte[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.KeyValuePair<System.Byte, System.Int32> @key = (System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>)typeof(System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>, System.Byte[]> instance_of_this_method = (System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>, System.Byte[]>)typeof(System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>, System.Byte[]>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method[key] = value;

            return __ret;
        }

        static StackObject* Add_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Byte[] @value = (System.Byte[])typeof(System.Byte[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.KeyValuePair<System.Byte, System.Int32> @key = (System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>)typeof(System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>, System.Byte[]> instance_of_this_method = (System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>, System.Byte[]>)typeof(System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Byte, System.Int32>, System.Byte[]>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Add(@key, @value);

            return __ret;
        }



    }
}
