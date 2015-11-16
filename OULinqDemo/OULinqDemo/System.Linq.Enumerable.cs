#region 程序集 System.Core.dll, v3.5.0.0
// C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\v3.5\System.Core.dll
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq
{
    // 摘要:
    //     提供一组用于查询实现 System.Collections.Generic.IEnumerable<T> 的对象的 static（在 Visual
    //     Basic 中为 Shared）方法。
    public static class Enumerable
    {
        // 摘要:
        //     对序列应用累加器函数。
        //
        // 参数:
        //   source:
        //     要聚合的 System.Collections.Generic.IEnumerable<T>。
        //
        //   func:
        //     要对每个元素调用的累加器函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     累加器的最终值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 func 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static TSource Aggregate<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func);
        //
        // 摘要:
        //     对序列应用累加器函数。将指定的种子值用作累加器初始值。
        //
        // 参数:
        //   source:
        //     要聚合的 System.Collections.Generic.IEnumerable<T>。
        //
        //   seed:
        //     累加器的初始值。
        //
        //   func:
        //     要对每个元素调用的累加器函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TAccumulate:
        //     累加器值的类型。
        //
        // 返回结果:
        //     累加器的最终值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 func 为 null。
        public static TAccumulate Aggregate<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func);
        //
        // 摘要:
        //     对序列应用累加器函数。将指定的种子值用作累加器的初始值，并使用指定的函数选择结果值。
        //
        // 参数:
        //   source:
        //     要聚合的 System.Collections.Generic.IEnumerable<T>。
        //
        //   seed:
        //     累加器的初始值。
        //
        //   func:
        //     要对每个元素调用的累加器函数。
        //
        //   resultSelector:
        //     将累加器的最终值转换为结果值的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TAccumulate:
        //     累加器值的类型。
        //
        //   TResult:
        //     结果值的类型。
        //
        // 返回结果:
        //     已转换的累加器最终值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 func 或 resultSelector 为 null。
        public static TResult Aggregate<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector);
        //
        // 摘要:
        //     确定序列中的所有元素是否满足条件。
        //
        // 参数:
        //   source:
        //     包含要应用谓词的元素的 System.Collections.Generic.IEnumerable<T>。
        //
        //   predicate:
        //     用于测试每个元素是否满足条件的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     如果源序列中的每个元素都通过指定谓词中的测试，或者序列为空，则为 true；否则为 false。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 predicate 为 null。
        public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
        //
        // 摘要:
        //     确定序列是否包含任何元素。
        //
        // 参数:
        //   source:
        //     要检查是否为空的 System.Collections.Generic.IEnumerable<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     如果源序列包含任何元素，则为 true；否则为 false。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static bool Any<TSource>(this IEnumerable<TSource> source);
        //
        // 摘要:
        //     确定序列中的任何元素是否都满足条件。
        //
        // 参数:
        //   source:
        //     一个 System.Collections.Generic.IEnumerable<T>，其元素将应用谓词。
        //
        //   predicate:
        //     用于测试每个元素是否满足条件的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     如果源序列中的任何元素都通过指定谓词中的测试，则为 true；否则为 false。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 predicate 为 null。
        public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
        //
        // 摘要:
        //     返回类型为 System.Collections.Generic.IEnumerable<T> 的输入。
        //
        // 参数:
        //   source:
        //     类型为 System.Collections.Generic.IEnumerable<T> 的序列。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     类型为 System.Collections.Generic.IEnumerable<T> 的输入序列。
        public static IEnumerable<TSource> AsEnumerable<TSource>(this IEnumerable<TSource> source);
        //
        // 摘要:
        //     计算可以为 null 的 System.Decimal 值序列的平均值。
        //
        // 参数:
        //   source:
        //     要计算平均值的可以为 null 的 System.Decimal 值序列。
        //
        // 返回结果:
        //     值序列的平均值；如果源序列为空或仅包含为 null 的值，则为 null。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.OverflowException:
        //     序列中元素之和大于 System.Decimal.MaxValue。
        public static decimal? Average(this IEnumerable<decimal?> source);
        //
        // 摘要:
        //     计算 System.Decimal 值序列的平均值。
        //
        // 参数:
        //   source:
        //     要计算平均值的 System.Decimal 值序列。
        //
        // 返回结果:
        //     值序列的平均值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        //
        //   System.OverflowException:
        //     序列中元素之和大于 System.Decimal.MaxValue。
        public static decimal Average(this IEnumerable<decimal> source);
        //
        // 摘要:
        //     计算可以为 null 的 System.Double 值序列的平均值。
        //
        // 参数:
        //   source:
        //     要计算平均值的可以为 null 的 System.Double 值序列。
        //
        // 返回结果:
        //     值序列的平均值；如果源序列为空或仅包含为 null 的值，则为 null。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static double? Average(this IEnumerable<double?> source);
        //
        // 摘要:
        //     计算 System.Double 值序列的平均值。
        //
        // 参数:
        //   source:
        //     要计算平均值的 System.Double 值序列。
        //
        // 返回结果:
        //     值序列的平均值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static double Average(this IEnumerable<double> source);
        //
        // 摘要:
        //     计算可以为 null 的 System.Single 值序列的平均值。
        //
        // 参数:
        //   source:
        //     要计算平均值的可以为 null 的 System.Single 值序列。
        //
        // 返回结果:
        //     值序列的平均值；如果源序列为空或仅包含为 null 的值，则为 null。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static float? Average(this IEnumerable<float?> source);
        //
        // 摘要:
        //     计算 System.Single 值序列的平均值。
        //
        // 参数:
        //   source:
        //     要计算平均值的 System.Single 值序列。
        //
        // 返回结果:
        //     值序列的平均值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static float Average(this IEnumerable<float> source);
        //
        // 摘要:
        //     计算可以为 null 的 System.Int32 值序列的平均值。
        //
        // 参数:
        //   source:
        //     要计算平均值的可以为 null 的 System.Int32 值序列。
        //
        // 返回结果:
        //     值序列的平均值；如果源序列为空或仅包含为 null 的值，则为 null。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.OverflowException:
        //     序列中元素之和大于 System.Int64.MaxValue。
        public static double? Average(this IEnumerable<int?> source);
        //
        // 摘要:
        //     计算 System.Int32 值序列的平均值。
        //
        // 参数:
        //   source:
        //     要计算平均值的 System.Int32 值序列。
        //
        // 返回结果:
        //     值序列的平均值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        //
        //   System.OverflowException:
        //     序列中元素之和大于 System.Int64.MaxValue。
        public static double Average(this IEnumerable<int> source);
        //
        // 摘要:
        //     计算可以为 null 的 System.Int64 值序列的平均值。
        //
        // 参数:
        //   source:
        //     要计算平均值的可以为 null 的 System.Int64 值序列。
        //
        // 返回结果:
        //     值序列的平均值；如果源序列为空或仅包含为 null 的值，则为 null。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.OverflowException:
        //     序列中元素之和大于 System.Int64.MaxValue。
        public static double? Average(this IEnumerable<long?> source);
        //
        // 摘要:
        //     计算 System.Int64 值序列的平均值。
        //
        // 参数:
        //   source:
        //     要计算平均值的 System.Int64 值序列。
        //
        // 返回结果:
        //     值序列的平均值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        //
        //   System.OverflowException:
        //     序列中元素之和大于 System.Int64.MaxValue。
        public static double Average(this IEnumerable<long> source);
        //
        // 摘要:
        //     计算可以为 null 的 System.Decimal 值序列的平均值，该值可通过调用输入序列的每个元素的转换函数获取。
        //
        // 参数:
        //   source:
        //     要计算其平均值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     值序列的平均值；如果源序列为空或仅包含为 null 的值，则为 null。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.OverflowException:
        //     序列中元素之和大于 System.Decimal.MaxValue。
        public static decimal? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector);
        //
        // 摘要:
        //     计算 System.Decimal 值序列的平均值，该值可通过调用输入序列的每个元素的转换函数获取。
        //
        // 参数:
        //   source:
        //     用于计算平均值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     值序列的平均值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        //
        //   System.OverflowException:
        //     序列中元素之和大于 System.Decimal.MaxValue。
        public static decimal Average<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector);
        //
        // 摘要:
        //     计算可以为 null 的 System.Double 值序列的平均值，该值可通过调用输入序列的每个元素的转换函数获取。
        //
        // 参数:
        //   source:
        //     要计算其平均值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     值序列的平均值；如果源序列为空或仅包含为 null 的值，则为 null。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector);
        //
        // 摘要:
        //     计算 System.Double 值序列的平均值，该值可通过调用输入序列的每个元素的转换函数获取。
        //
        // 参数:
        //   source:
        //     要计算其平均值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     值序列的平均值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector);
        //
        // 摘要:
        //     计算可以为 null 的 System.Single 值序列的平均值，该值可通过调用输入序列的每个元素的转换函数获取。
        //
        // 参数:
        //   source:
        //     要计算其平均值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     值序列的平均值；如果源序列为空或仅包含为 null 的值，则为 null。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static float? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector);
        //
        // 摘要:
        //     计算 System.Single 值序列的平均值，该值可通过调用输入序列的每个元素的转换函数获取。
        //
        // 参数:
        //   source:
        //     要计算其平均值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     值序列的平均值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static float Average<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector);
        //
        // 摘要:
        //     计算可以为 null 的 System.Int32 值序列的平均值，该值可通过调用输入序列的每个元素的转换函数获取。
        //
        // 参数:
        //   source:
        //     要计算其平均值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     值序列的平均值；如果源序列为空或仅包含为 null 的值，则为 null。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.OverflowException:
        //     序列中元素之和大于 System.Int64.MaxValue。
        public static double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector);
        //
        // 摘要:
        //     计算 System.Int32 值序列的平均值，该值可通过调用输入序列的每个元素的转换函数获取。
        //
        // 参数:
        //   source:
        //     要计算其平均值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     值序列的平均值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        //
        //   System.OverflowException:
        //     序列中元素之和大于 System.Int64.MaxValue。
        public static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector);
        //
        // 摘要:
        //     计算可以为 null 的 System.Int64 值序列的平均值，该值可通过调用输入序列的每个元素的转换函数获取。
        //
        // 参数:
        //   source:
        //     要计算其平均值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     值序列的平均值；如果源序列为空或仅包含为 null 的值，则为 null。
        public static double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector);
        //
        // 摘要:
        //     计算 System.Int64 值序列的平均值，该值可通过调用输入序列的每个元素的转换函数获取。
        //
        // 参数:
        //   source:
        //     要计算其平均值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     值序列的平均值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        //
        //   System.OverflowException:
        //     序列中元素之和大于 System.Int64.MaxValue。
        public static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector);
        //
        // 摘要:
        //     将 System.Collections.IEnumerable 的元素转换为指定的类型。
        //
        // 参数:
        //   source:
        //     包含要转换的元素的 System.Collections.IEnumerable。
        //
        // 类型参数:
        //   TResult:
        //     source 中的元素要转换成的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，包含已转换为指定类型的源序列的每个元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidCastException:
        //     序列中的元素不能强制转换为 TResult 类型。
        public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source);
        //
        // 摘要:
        //     连接两个序列。
        //
        // 参数:
        //   first:
        //     要连接的第一个序列。
        //
        //   second:
        //     要与第一个序列连接的序列。
        //
        // 类型参数:
        //   TSource:
        //     输入序列中的元素的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，包含两个输入序列的连接元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     first 或 second 为 null。
        public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second);
        //
        // 摘要:
        //     通过使用默认的相等比较器确定序列是否包含指定的元素。
        //
        // 参数:
        //   source:
        //     要在其中定位某个值的序列。
        //
        //   value:
        //     要在序列中定位的值。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     如果源序列包含具有指定值的元素，则为 true；否则为 false。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value);
        //
        // 摘要:
        //     通过使用指定的 System.Collections.Generic.IEqualityComparer<T> 确定序列是否包含指定的元素。
        //
        // 参数:
        //   source:
        //     要在其中定位某个值的序列。
        //
        //   value:
        //     要在序列中定位的值。
        //
        //   comparer:
        //     一个对值进行比较的相等比较器。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     如果源序列包含具有指定值的元素，则为 true；否则为 false。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer);
        //
        // 摘要:
        //     返回序列中的元素数量。
        //
        // 参数:
        //   source:
        //     包含要计数的元素的序列。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     输入序列中的元素数量。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.OverflowException:
        //     source 中的元素数量大于 System.Int32.MaxValue。
        public static int Count<TSource>(this IEnumerable<TSource> source);
        //
        // 摘要:
        //     返回一个数字，表示在指定的序列中满足条件的元素数量。
        //
        // 参数:
        //   source:
        //     包含要测试和计数的元素的序列。
        //
        //   predicate:
        //     用于测试每个元素是否满足条件的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     一个数字，表示序列中满足谓词函数条件的元素数量。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 predicate 为 null。
        //
        //   System.OverflowException:
        //     source 中的元素数量大于 System.Int32.MaxValue。
        public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
        //
        // 摘要:
        //     返回指定序列的元素；如果序列为空，则返回单一实例集合中的类型参数的默认值。
        //
        // 参数:
        //   source:
        //     序列为空时返回默认值的序列。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     如果 source 为空，则为包含 default(TSource) 的 System.Collections.Generic.IEnumerable<T>；否则为
        //     source。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this IEnumerable<TSource> source);
        //
        // 摘要:
        //     返回指定序列中的元素；如果序列为空，则返回单一实例集合中的指定值。
        //
        // 参数:
        //   source:
        //     序列为空时为其返回指定值的序列。
        //
        //   defaultValue:
        //     序列为空时要返回的值。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     如果 source 为空，则为包含 defaultValue 的 System.Collections.Generic.IEnumerable<T>；否则为
        //     source。
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this IEnumerable<TSource> source, TSource defaultValue);
        //
        // 摘要:
        //     通过使用默认的相等比较器对值进行比较返回序列中的非重复元素。
        //
        // 参数:
        //   source:
        //     要从中移除重复元素的序列。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，包含源序列中的非重复元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source);
        //
        // 摘要:
        //     通过使用指定的 System.Collections.Generic.IEqualityComparer<T> 对值进行比较返回序列中的非重复元素。
        //
        // 参数:
        //   source:
        //     要从中移除重复元素的序列。
        //
        //   comparer:
        //     用于比较值的 System.Collections.Generic.IEqualityComparer<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，包含源序列中的非重复元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer);
        //
        // 摘要:
        //     返回序列中指定索引处的元素。
        //
        // 参数:
        //   source:
        //     要从中返回元素的 System.Collections.Generic.IEnumerable<T>。
        //
        //   index:
        //     要检索的从零开始的元素索引。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     源序列中指定位置处的元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.ArgumentOutOfRangeException:
        //     index 小于零或大于等于 source 中的元素数量。
        public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index);
        //
        // 摘要:
        //     返回序列中指定索引处的元素；如果索引超出范围，则返回默认值。
        //
        // 参数:
        //   source:
        //     要从中返回元素的 System.Collections.Generic.IEnumerable<T>。
        //
        //   index:
        //     要检索的从零开始的元素索引。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     如果索引超出源序列的范围，则为 default(TSource)；否则为源序列中指定位置处的元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static TSource ElementAtOrDefault<TSource>(this IEnumerable<TSource> source, int index);
        //
        // 摘要:
        //     返回一个具有指定的类型参数的空 System.Collections.Generic.IEnumerable<T>。
        //
        // 类型参数:
        //   TResult:
        //     分配给返回的泛型 System.Collections.Generic.IEnumerable<T> 的类型参数的类型。
        //
        // 返回结果:
        //     一个类型参数为 TResult 的空 System.Collections.Generic.IEnumerable<T>。
        public static IEnumerable<TResult> Empty<TResult>();
        //
        // 摘要:
        //     通过使用默认的相等比较器对值进行比较生成两个序列的差集。
        //
        // 参数:
        //   first:
        //     一个 System.Collections.Generic.IEnumerable<T>，将返回其也不在 second 中的元素。
        //
        //   second:
        //     一个 System.Collections.Generic.IEnumerable<T>，如果它的元素也出现在第一个序列中，则将导致从返回的序列中移除这些元素。
        //
        // 类型参数:
        //   TSource:
        //     输入序列中的元素的类型。
        //
        // 返回结果:
        //     包含两个序列元素的差集的序列。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     first 或 second 为 null。
        public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second);
        //
        // 摘要:
        //     通过使用指定的 System.Collections.Generic.IEqualityComparer<T> 对值进行比较产生两个序列的差集。
        //
        // 参数:
        //   first:
        //     一个 System.Collections.Generic.IEnumerable<T>，将返回其也不在 second 中的元素。
        //
        //   second:
        //     一个 System.Collections.Generic.IEnumerable<T>，如果它的元素也出现在第一个序列中，则将导致从返回的序列中移除这些元素。
        //
        //   comparer:
        //     用于比较值的 System.Collections.Generic.IEqualityComparer<T>。
        //
        // 类型参数:
        //   TSource:
        //     输入序列中的元素的类型。
        //
        // 返回结果:
        //     包含两个序列元素的差集的序列。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     first 或 second 为 null。
        public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer);
        //
        // 摘要:
        //     返回序列中的第一个元素。
        //
        // 参数:
        //   source:
        //     要返回其第一个元素的 System.Collections.Generic.IEnumerable<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     返回指定序列中的第一个元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     源序列为空。
        public static TSource First<TSource>(this IEnumerable<TSource> source);
        //
        // 摘要:
        //     返回序列中满足指定条件的第一个元素。
        //
        // 参数:
        //   source:
        //     要从中返回元素的 System.Collections.Generic.IEnumerable<T>。
        //
        //   predicate:
        //     用于测试每个元素是否满足条件的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     序列中通过指定谓词函数中的测试的第一个元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 predicate 为 null。
        //
        //   System.InvalidOperationException:
        //     没有元素满足 predicate 中的条件。 - 或 - 源序列为空。
        public static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
        //
        // 摘要:
        //     返回序列中的第一个元素；如果序列中不包含任何元素，则返回默认值。
        //
        // 参数:
        //   source:
        //     要返回其第一个元素的 System.Collections.Generic.IEnumerable<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     如果 source 为空，则返回 default(TSource)；否则返回 source 中的第一个元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source);
        //
        // 摘要:
        //     返回序列中满足条件的第一个元素；如果未找到这样的元素，则返回默认值。
        //
        // 参数:
        //   source:
        //     要从中返回元素的 System.Collections.Generic.IEnumerable<T>。
        //
        //   predicate:
        //     用于测试每个元素是否满足条件的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     如果 source 为空或没有元素通过 predicate 指定的测试，则返回 default(TSource)，否则返回 source 中通过
        //     predicate 指定的测试的第一个元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 predicate 为 null。
        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
        //
        // 摘要:
        //     根据指定的键选择器函数对序列中的元素进行分组。
        //
        // 参数:
        //   source:
        //     要对其元素进行分组的 System.Collections.Generic.IEnumerable<T>。
        //
        //   keySelector:
        //     用于提取每个元素的键的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        // 返回结果:
        //     在 C# 中为 IEnumerable<IGrouping<TKey, TSource>>，或者在 Visual Basic 中为 IEnumerable(Of
        //     IGrouping(Of TKey, TSource))，其中每个 System.Linq.IGrouping<TKey,TElement> 对象都包含一个对象序列和一个键。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 为 null。
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector);
        //
        // 摘要:
        //     根据指定的键选择器函数对序列中的元素进行分组，并且从每个组及其键中创建结果值。
        //
        // 参数:
        //   source:
        //     要对其元素进行分组的 System.Collections.Generic.IEnumerable<T>。
        //
        //   keySelector:
        //     用于提取每个元素的键的函数。
        //
        //   resultSelector:
        //     用于从每个组中创建结果值的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        //   TResult:
        //     resultSelector 返回的结果值的类型。
        //
        // 返回结果:
        //     TResult 类型的元素的集合，其中每个元素都表示对一个组及其键的投影。
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector);
        //
        // 摘要:
        //     根据指定的键选择器函数对序列中的元素进行分组，并且通过使用指定的函数对每个组中的元素进行投影。
        //
        // 参数:
        //   source:
        //     要对其元素进行分组的 System.Collections.Generic.IEnumerable<T>。
        //
        //   keySelector:
        //     用于提取每个元素的键的函数。
        //
        //   elementSelector:
        //     用于将每个源元素映射到 System.Linq.IGrouping<TKey,TElement> 中的元素的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        //   TElement:
        //     System.Linq.IGrouping<TKey,TElement> 中的元素的类型。
        //
        // 返回结果:
        //     在 C# 中为 IEnumerable<IGrouping<TKey, TElement>>，或者在 Visual Basic 中为 IEnumerable(Of
        //     IGrouping(Of TKey, TElement))，其中每个 System.Linq.IGrouping<TKey,TElement> 对象都包含一个类型为
        //     TElement 的对象集合和一个键。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 或 elementSelector 为 null。
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector);
        //
        // 摘要:
        //     根据指定的键选择器函数对序列中的元素进行分组，并使用指定的比较器对键进行比较。
        //
        // 参数:
        //   source:
        //     要对其元素进行分组的 System.Collections.Generic.IEnumerable<T>。
        //
        //   keySelector:
        //     用于提取每个元素的键的函数。
        //
        //   comparer:
        //     一个用于对键进行比较的 System.Collections.Generic.IEqualityComparer<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        // 返回结果:
        //     在 C# 中为 IEnumerable<IGrouping<TKey, TSource>>，或者在 Visual Basic 中为 IEnumerable(Of
        //     IGrouping(Of TKey, TSource))，其中每个 System.Linq.IGrouping<TKey,TElement> 对象都包含一个对象集合和一个键。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 为 null。
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer);
        //
        // 摘要:
        //     根据指定的键选择器函数对序列中的元素进行分组，并且从每个组及其键中创建结果值。通过使用指定的比较器对键进行比较。
        //
        // 参数:
        //   source:
        //     要对其元素进行分组的 System.Collections.Generic.IEnumerable<T>。
        //
        //   keySelector:
        //     用于提取每个元素的键的函数。
        //
        //   resultSelector:
        //     用于从每个组中创建结果值的函数。
        //
        //   comparer:
        //     一个用于对键进行比较的 System.Collections.Generic.IEqualityComparer<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        //   TResult:
        //     resultSelector 返回的结果值的类型。
        //
        // 返回结果:
        //     TResult 类型的元素的集合，其中每个元素都表示对一个组及其键的投影。
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector, IEqualityComparer<TKey> comparer);
        //
        // 摘要:
        //     根据指定的键选择器函数对序列中的元素进行分组，并且从每个组及其键中创建结果值。通过使用指定的函数对每个组的元素进行投影。
        //
        // 参数:
        //   source:
        //     要对其元素进行分组的 System.Collections.Generic.IEnumerable<T>。
        //
        //   keySelector:
        //     用于提取每个元素的键的函数。
        //
        //   elementSelector:
        //     用于将每个源元素映射到 System.Linq.IGrouping<TKey,TElement> 中的元素的函数。
        //
        //   resultSelector:
        //     用于从每个组中创建结果值的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        //   TElement:
        //     每个 System.Linq.IGrouping<TKey,TElement> 中的元素的类型。
        //
        //   TResult:
        //     resultSelector 返回的结果值的类型。
        //
        // 返回结果:
        //     TResult 类型的元素的集合，其中每个元素都表示对一个组及其键的投影。
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector);
        //
        // 摘要:
        //     根据键选择器函数对序列中的元素进行分组。通过使用比较器对键进行比较，并且通过使用指定的函数对每个组的元素进行投影。
        //
        // 参数:
        //   source:
        //     要对其元素进行分组的 System.Collections.Generic.IEnumerable<T>。
        //
        //   keySelector:
        //     用于提取每个元素的键的函数。
        //
        //   elementSelector:
        //     用于将每个源元素映射到 System.Linq.IGrouping<TKey,TElement> 中的元素的函数。
        //
        //   comparer:
        //     一个用于对键进行比较的 System.Collections.Generic.IEqualityComparer<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        //   TElement:
        //     System.Linq.IGrouping<TKey,TElement> 中的元素的类型。
        //
        // 返回结果:
        //     在 C# 中为 IEnumerable<IGrouping<TKey, TElement>>，或者在 Visual Basic 中为 IEnumerable(Of
        //     IGrouping(Of TKey, TElement))，其中每个 System.Linq.IGrouping<TKey,TElement> 对象都包含一个类型为
        //     TElement 的对象集合和一个键。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 或 elementSelector 为 null。
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer);
        //
        // 摘要:
        //     根据指定的键选择器函数对序列中的元素进行分组，并且从每个组及其键中创建结果值。通过使用指定的比较器对键值进行比较，并且通过使用指定的函数对每个组的元素进行投影。
        //
        // 参数:
        //   source:
        //     要对其元素进行分组的 System.Collections.Generic.IEnumerable<T>。
        //
        //   keySelector:
        //     用于提取每个元素的键的函数。
        //
        //   elementSelector:
        //     用于将每个源元素映射到 System.Linq.IGrouping<TKey,TElement> 中的元素的函数。
        //
        //   resultSelector:
        //     用于从每个组中创建结果值的函数。
        //
        //   comparer:
        //     一个用于对键进行比较的 System.Collections.Generic.IEqualityComparer<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        //   TElement:
        //     每个 System.Linq.IGrouping<TKey,TElement> 中的元素的类型。
        //
        //   TResult:
        //     resultSelector 返回的结果值的类型。
        //
        // 返回结果:
        //     TResult 类型的元素的集合，其中每个元素都表示对一个组及其键的投影。
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer);
        //
        // 摘要:
        //     基于键相等对两个序列的元素进行关联并对结果进行分组。使用默认的相等比较器对键进行比较。
        //
        // 参数:
        //   outer:
        //     要联接的第一个序列。
        //
        //   inner:
        //     要与第一个序列联接的序列。
        //
        //   outerKeySelector:
        //     用于从第一个序列的每个元素提取联接键的函数。
        //
        //   innerKeySelector:
        //     用于从第二个序列的每个元素提取联接键的函数。
        //
        //   resultSelector:
        //     用于从第一个序列的元素和第二个序列的匹配元素集合中创建结果元素的函数。
        //
        // 类型参数:
        //   TOuter:
        //     第一个序列中的元素的类型。
        //
        //   TInner:
        //     第二个序列中的元素的类型。
        //
        //   TKey:
        //     键选择器函数返回的键的类型。
        //
        //   TResult:
        //     结果元素的类型。
        //
        // 返回结果:
        //     一个包含 TResult 类型的元素的 System.Collections.Generic.IEnumerable<T>，这些元素可通过对两个序列执行分组联接获取。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     outer 或 inner 或 outerKeySelector 或 innerKeySelector 或 resultSelector 为 null。
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector);
        //
        // 摘要:
        //     基于键相等对两个序列的元素进行关联并对结果进行分组。使用指定的 System.Collections.Generic.IEqualityComparer<T>
        //     对键进行比较。
        //
        // 参数:
        //   outer:
        //     要联接的第一个序列。
        //
        //   inner:
        //     要与第一个序列联接的序列。
        //
        //   outerKeySelector:
        //     用于从第一个序列的每个元素提取联接键的函数。
        //
        //   innerKeySelector:
        //     用于从第二个序列的每个元素提取联接键的函数。
        //
        //   resultSelector:
        //     用于从第一个序列的元素和第二个序列的匹配元素集合中创建结果元素的函数。
        //
        //   comparer:
        //     一个 System.Collections.Generic.IEqualityComparer<T>，用于对键进行哈希处理和比较。
        //
        // 类型参数:
        //   TOuter:
        //     第一个序列中的元素的类型。
        //
        //   TInner:
        //     第二个序列中的元素的类型。
        //
        //   TKey:
        //     键选择器函数返回的键的类型。
        //
        //   TResult:
        //     结果元素的类型。
        //
        // 返回结果:
        //     一个包含 TResult 类型的元素的 System.Collections.Generic.IEnumerable<T>，这些元素可通过对两个序列执行分组联接获取。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     outer 或 inner 或 outerKeySelector 或 innerKeySelector 或 resultSelector 为 null。
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector, IEqualityComparer<TKey> comparer);
        //
        // 摘要:
        //     通过使用默认的相等比较器对值进行比较生成两个序列的交集。
        //
        // 参数:
        //   first:
        //     一个 System.Collections.Generic.IEnumerable<T>，将返回其也出现在 second 中的非重复元素。
        //
        //   second:
        //     一个 System.Collections.Generic.IEnumerable<T>，将返回其也出现在第一个序列中的非重复元素。
        //
        // 类型参数:
        //   TSource:
        //     输入序列中的元素的类型。
        //
        // 返回结果:
        //     包含组成两个序列交集的元素的序列。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     first 或 second 为 null。
        public static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second);
        //
        // 摘要:
        //     通过使用指定的 System.Collections.Generic.IEqualityComparer<T> 对值进行比较以生成两个序列的交集。
        //
        // 参数:
        //   first:
        //     一个 System.Collections.Generic.IEnumerable<T>，将返回其也出现在 second 中的非重复元素。
        //
        //   second:
        //     一个 System.Collections.Generic.IEnumerable<T>，将返回其也出现在第一个序列中的非重复元素。
        //
        //   comparer:
        //     用于比较值的 System.Collections.Generic.IEqualityComparer<T>。
        //
        // 类型参数:
        //   TSource:
        //     输入序列中的元素的类型。
        //
        // 返回结果:
        //     包含组成两个序列交集的元素的序列。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     first 或 second 为 null。
        public static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer);
        //
        // 摘要:
        //     基于匹配键对两个序列的元素进行关联。使用默认的相等比较器对键进行比较。
        //
        // 参数:
        //   outer:
        //     要联接的第一个序列。
        //
        //   inner:
        //     要与第一个序列联接的序列。
        //
        //   outerKeySelector:
        //     用于从第一个序列的每个元素提取联接键的函数。
        //
        //   innerKeySelector:
        //     用于从第二个序列的每个元素提取联接键的函数。
        //
        //   resultSelector:
        //     用于从两个匹配元素创建结果元素的函数。
        //
        // 类型参数:
        //   TOuter:
        //     第一个序列中的元素的类型。
        //
        //   TInner:
        //     第二个序列中的元素的类型。
        //
        //   TKey:
        //     键选择器函数返回的键的类型。
        //
        //   TResult:
        //     结果元素的类型。
        //
        // 返回结果:
        //     一个具有 TResult 类型元素的 System.Collections.Generic.IEnumerable<T>，这些元素是通过对两个序列执行内部联接得来的。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     outer 或 inner 或 outerKeySelector 或 innerKeySelector 或 resultSelector 为 null。
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector);
        //
        // 摘要:
        //     基于匹配键对两个序列的元素进行关联。使用指定的 System.Collections.Generic.IEqualityComparer<T> 对键进行比较。
        //
        // 参数:
        //   outer:
        //     要联接的第一个序列。
        //
        //   inner:
        //     要与第一个序列联接的序列。
        //
        //   outerKeySelector:
        //     用于从第一个序列的每个元素提取联接键的函数。
        //
        //   innerKeySelector:
        //     用于从第二个序列的每个元素提取联接键的函数。
        //
        //   resultSelector:
        //     用于从两个匹配元素创建结果元素的函数。
        //
        //   comparer:
        //     一个 System.Collections.Generic.IEqualityComparer<T>，用于对键进行哈希处理和比较。
        //
        // 类型参数:
        //   TOuter:
        //     第一个序列中的元素的类型。
        //
        //   TInner:
        //     第二个序列中的元素的类型。
        //
        //   TKey:
        //     键选择器函数返回的键的类型。
        //
        //   TResult:
        //     结果元素的类型。
        //
        // 返回结果:
        //     一个具有 TResult 类型元素的 System.Collections.Generic.IEnumerable<T>，这些元素是通过对两个序列执行内部联接得来的。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     outer 或 inner 或 outerKeySelector 或 innerKeySelector 或 resultSelector 为 null。
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer);
        //
        // 摘要:
        //     返回序列的最后一个元素。
        //
        // 参数:
        //   source:
        //     要返回其最后一个元素的 System.Collections.Generic.IEnumerable<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     源序列中最后位置处的值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     源序列为空。
        public static TSource Last<TSource>(this IEnumerable<TSource> source);
        //
        // 摘要:
        //     返回序列中满足指定条件的最后一个元素。
        //
        // 参数:
        //   source:
        //     要从中返回元素的 System.Collections.Generic.IEnumerable<T>。
        //
        //   predicate:
        //     用于测试每个元素是否满足条件的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     序列中通过指定谓词函数中的测试的最后一个元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 predicate 为 null。
        //
        //   System.InvalidOperationException:
        //     没有元素满足 predicate 中的条件。 - 或 - 源序列为空。
        public static TSource Last<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
        //
        // 摘要:
        //     返回序列中的最后一个元素；如果序列中不包含任何元素，则返回默认值。
        //
        // 参数:
        //   source:
        //     要返回其最后一个元素的 System.Collections.Generic.IEnumerable<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     如果源序列为空，则返回 default(TSource)；否则返回 System.Collections.Generic.IEnumerable<T>
        //     中的最后一个元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source);
        //
        // 摘要:
        //     返回序列中满足条件的最后一个元素；如果未找到这样的元素，则返回默认值。
        //
        // 参数:
        //   source:
        //     要从中返回元素的 System.Collections.Generic.IEnumerable<T>。
        //
        //   predicate:
        //     用于测试每个元素是否满足条件的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     如果序列为空或没有元素通过谓词函数中的测试，则返回 default(TSource)；否则返回通过谓词函数中的测试的最后一个元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 predicate 为 null。
        public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
        //
        // 摘要:
        //     返回一个 System.Int64，表示序列中的元素的总数量。
        //
        // 参数:
        //   source:
        //     包含要进行计数的元素的 System.Collections.Generic.IEnumerable<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     源序列中的元素的数量。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.OverflowException:
        //     元素的数量超过 System.Int64.MaxValue。
        public static long LongCount<TSource>(this IEnumerable<TSource> source);
        //
        // 摘要:
        //     返回一个 System.Int64，表示序列中满足条件的元素的数量。
        //
        // 参数:
        //   source:
        //     包含要进行计数的元素的 System.Collections.Generic.IEnumerable<T>。
        //
        //   predicate:
        //     用于测试每个元素是否满足条件的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     一个数字，表示序列中满足谓词函数条件的元素数量。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 predicate 为 null。
        //
        //   System.OverflowException:
        //     匹配元素的数量超过 System.Int64.MaxValue。
        public static long LongCount<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
        //
        // 摘要:
        //     返回可以为 null 的 System.Decimal 值序列中的最大值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的可以为 null 的 System.Decimal 值序列。
        //
        // 返回结果:
        //     一个与序列中的最大值对应的值，该值的类型在 C# 中为 Nullable<Decimal>，在 Visual Basic 中为 Nullable(Of
        //     Decimal)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static decimal? Max(this IEnumerable<decimal?> source);
        //
        // 摘要:
        //     返回 System.Decimal 值序列中的最大值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的 System.Decimal 值序列。
        //
        // 返回结果:
        //     序列中的最大值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static decimal Max(this IEnumerable<decimal> source);
        //
        // 摘要:
        //     返回可以为 null 的 System.Double 值序列中的最大值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的可以为 null 的 System.Double 值序列。
        //
        // 返回结果:
        //     一个与序列中的最大值对应的值，该值的类型在 C# 中为 Nullable<Double>，在 Visual Basic 中为 Nullable(Of
        //     Double)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static double? Max(this IEnumerable<double?> source);
        //
        // 摘要:
        //     返回 System.Double 值序列中的最大值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的 System.Double 值序列。
        //
        // 返回结果:
        //     序列中的最大值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static double Max(this IEnumerable<double> source);
        //
        // 摘要:
        //     返回可以为 null 的 System.Single 值序列中的最大值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的可以为 null 的 System.Single 值序列。
        //
        // 返回结果:
        //     一个与序列中的最大值对应的值，该值的类型在 C# 中为 Nullable<Single>，在 Visual Basic 中为 Nullable(Of
        //     Single)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static float? Max(this IEnumerable<float?> source);
        //
        // 摘要:
        //     返回 System.Single 值序列中的最大值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的 System.Single 值序列。
        //
        // 返回结果:
        //     序列中的最大值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static float Max(this IEnumerable<float> source);
        //
        // 摘要:
        //     返回可以为 null 的 System.Int32 值序列中的最大值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的可以为 null 的 System.Int32 值序列。
        //
        // 返回结果:
        //     一个与序列中的最大值对应的值，该值的类型在 C# 中为 Nullable<Int32>，在 Visual Basic 中为 Nullable(Of
        //     Int32)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static int? Max(this IEnumerable<int?> source);
        //
        // 摘要:
        //     返回 System.Int32 值序列中的最大值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的 System.Int32 值序列。
        //
        // 返回结果:
        //     序列中的最大值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static int Max(this IEnumerable<int> source);
        //
        // 摘要:
        //     返回可以为 null 的 System.Int64 值序列中的最大值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的可以为 null 的 System.Int64 值序列。
        //
        // 返回结果:
        //     一个与序列中的最大值对应的值，该值的类型在 C# 中为 Nullable<Int64>，在 Visual Basic 中为 Nullable(Of
        //     Int64)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static long? Max(this IEnumerable<long?> source);
        //
        // 摘要:
        //     返回 System.Int64 值序列中的最大值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的 System.Int64 值序列。
        //
        // 返回结果:
        //     序列中的最大值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static long Max(this IEnumerable<long> source);
        //
        // 摘要:
        //     返回泛型序列中的最大值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的值序列。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     序列中的最大值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static TSource Max<TSource>(this IEnumerable<TSource> source);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回可空 System.Decimal 的最大值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     C# 中类型为 Nullable<Decimal> 的值或 Visual Basic 中与序列中最大值对应的 Nullable(Of Decimal)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static decimal? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回最大 System.Decimal 值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     序列中的最大值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static decimal Max<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回可空 System.Double 的最大值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     C# 中类型为 Nullable<Double> 的值或 Visual Basic 中与序列中最大值对应的 Nullable(Of Double)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static double? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回最大 System.Double 值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     序列中的最大值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static double Max<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回可空 System.Single 的最大值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     C# 中类型为 Nullable<Single> 的值或 Visual Basic 中与序列中最大值对应的 Nullable(Of Single)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static float? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回最大 System.Single 值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     序列中的最大值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static float Max<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回可空 System.Int32 的最大值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     C# 中类型为 Nullable<Int32> 的值或 Visual Basic 中与序列中最大值对应的 Nullable(Of Int32)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static int? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回最大 System.Int32 值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     序列中的最大值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static int Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回可空 System.Int64 的最大值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     C# 中类型为 Nullable<Int64> 的值或 Visual Basic 中与序列中最大值对应的 Nullable(Of Int64)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static long? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回最大 System.Int64 值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     序列中的最大值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static long Max<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector);
        //
        // 摘要:
        //     调用泛型序列的每个元素上的转换函数并返回最大结果值。
        //
        // 参数:
        //   source:
        //     要确定其最大值的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TResult:
        //     selector 返回的值的类型。
        //
        // 返回结果:
        //     序列中的最大值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static TResult Max<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector);
        //
        // 摘要:
        //     返回 System.Decimal 值（可空）序列中的最小值。
        //
        // 参数:
        //   source:
        //     一个可空 System.Decimal 值的序列，用于确定最小值。
        //
        // 返回结果:
        //     C# 中类型为 Nullable<Decimal> 的值或 Visual Basic 中与序列中最小值对应的 Nullable(Of Decimal)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static decimal? Min(this IEnumerable<decimal?> source);
        //
        // 摘要:
        //     返回 System.Decimal 值序列中的最小值。
        //
        // 参数:
        //   source:
        //     一个 System.Decimal 值序列，用于确定最大值。
        //
        // 返回结果:
        //     序列中的最小值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static decimal Min(this IEnumerable<decimal> source);
        //
        // 摘要:
        //     返回 System.Double 值（可空）序列中的最小值。
        //
        // 参数:
        //   source:
        //     一个可空 System.Double 值的序列，用于确定最小值。
        //
        // 返回结果:
        //     C# 中类型为 Nullable<Double> 的值或 Visual Basic 中与序列中最小值对应的 Nullable(Of Double)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static double? Min(this IEnumerable<double?> source);
        //
        // 摘要:
        //     返回 System.Double 值序列中的最小值。
        //
        // 参数:
        //   source:
        //     一个 System.Double 值序列，用于确定最小值。
        //
        // 返回结果:
        //     序列中的最小值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static double Min(this IEnumerable<double> source);
        //
        // 摘要:
        //     返回 System.Single 值（可空）序列中的最小值。
        //
        // 参数:
        //   source:
        //     一个可空 System.Single 值的序列，用于确定最小值。
        //
        // 返回结果:
        //     C# 中类型为 Nullable<Single> 的值或 Visual Basic 中与序列中最小值对应的 Nullable(Of Single)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static float? Min(this IEnumerable<float?> source);
        //
        // 摘要:
        //     返回 System.Single 值序列中的最小值。
        //
        // 参数:
        //   source:
        //     一个 System.Single 值序列，用于确定最小值。
        //
        // 返回结果:
        //     序列中的最小值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static float Min(this IEnumerable<float> source);
        //
        // 摘要:
        //     返回 System.Int32 值（可空）序列中的最小值。
        //
        // 参数:
        //   source:
        //     一个可空 System.Int32 值的序列，用于确定最小值。
        //
        // 返回结果:
        //     C# 中类型为 Nullable<Int32> 的值或 Visual Basic 中与序列中最小值对应的 Nullable(Of Int32)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static int? Min(this IEnumerable<int?> source);
        //
        // 摘要:
        //     返回 System.Int32 值序列中的最小值。
        //
        // 参数:
        //   source:
        //     一个 System.Int32 值序列，用于确定最小值。
        //
        // 返回结果:
        //     序列中的最小值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static int Min(this IEnumerable<int> source);
        //
        // 摘要:
        //     返回 System.Int64 值（可空）序列中的最小值。
        //
        // 参数:
        //   source:
        //     一个可空 System.Int64 值的序列，用于确定最小值。
        //
        // 返回结果:
        //     C# 中类型为 Nullable<Int64> 的值或 Visual Basic 中与序列中最小值对应的 Nullable(Of Int64)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static long? Min(this IEnumerable<long?> source);
        //
        // 摘要:
        //     返回 System.Int64 值序列中的最小值。
        //
        // 参数:
        //   source:
        //     一个 System.Int64 值序列，用于确定最小值。
        //
        // 返回结果:
        //     序列中的最小值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static long Min(this IEnumerable<long> source);
        //
        // 摘要:
        //     返回泛型序列中的最小值。
        //
        // 参数:
        //   source:
        //     一个值序列，用于确定最小值。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     序列中的最小值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static TSource Min<TSource>(this IEnumerable<TSource> source);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回可空 System.Decimal 的最小值。
        //
        // 参数:
        //   source:
        //     一个值序列，用于确定最小值。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     C# 中类型为 Nullable<Decimal> 的值或 Visual Basic 中与序列中最小值对应的 Nullable(Of Decimal)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static decimal? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回最小 System.Decimal 值。
        //
        // 参数:
        //   source:
        //     一个值序列，用于确定最小值。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     序列中的最小值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static decimal Min<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回可空 System.Double 的最小值。
        //
        // 参数:
        //   source:
        //     一个值序列，用于确定最小值。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     C# 中类型为 Nullable<Double> 的值或 Visual Basic 中与序列中最小值对应的 Nullable(Of Double)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static double? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回最小 System.Double 值。
        //
        // 参数:
        //   source:
        //     一个值序列，用于确定最小值。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     序列中的最小值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static double Min<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回可空 System.Single 的最小值。
        //
        // 参数:
        //   source:
        //     一个值序列，用于确定最小值。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     C# 中类型为 Nullable<Single> 的值或 Visual Basic 中与序列中最小值对应的 Nullable(Of Single)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static float? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回最小 System.Single 值。
        //
        // 参数:
        //   source:
        //     一个值序列，用于确定最小值。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     序列中的最小值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static float Min<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回可空 System.Int32 的最小值。
        //
        // 参数:
        //   source:
        //     一个值序列，用于确定最小值。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     C# 中类型为 Nullable<Int32> 的值或 Visual Basic 中与序列中最小值对应的 Nullable(Of Int32)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static int? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回最小 System.Int32 值。
        //
        // 参数:
        //   source:
        //     一个值序列，用于确定最小值。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     序列中的最小值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static int Min<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回可空 System.Int64 的最小值。
        //
        // 参数:
        //   source:
        //     一个值序列，用于确定最小值。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     C# 中类型为 Nullable<Int64> 的值或 Visual Basic 中与序列中最小值对应的 Nullable(Of Int64)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static long? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector);
        //
        // 摘要:
        //     调用序列的每个元素上的转换函数并返回最小 System.Int64 值。
        //
        // 参数:
        //   source:
        //     一个值序列，用于确定最小值。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     序列中的最小值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.InvalidOperationException:
        //     source 中不包含任何元素。
        public static long Min<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector);
        //
        // 摘要:
        //     调用泛型序列的每个元素上的转换函数并返回最小结果值。
        //
        // 参数:
        //   source:
        //     一个值序列，用于确定最小值。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TResult:
        //     selector 返回的值的类型。
        //
        // 返回结果:
        //     序列中的最小值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static TResult Min<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector);
        //
        // 摘要:
        //     根据指定类型筛选 System.Collections.IEnumerable 的元素。
        //
        // 参数:
        //   source:
        //     System.Collections.IEnumerable，其元素用于筛选。
        //
        // 类型参数:
        //   TResult:
        //     筛选序列元素所根据的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，包含类型为 TResult 的输入序列中的元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source);
        //
        // 摘要:
        //     根据键按升序对序列的元素排序。
        //
        // 参数:
        //   source:
        //     一个要排序的值序列。
        //
        //   keySelector:
        //     用于从元素中提取键的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        // 返回结果:
        //     一个 System.Linq.IOrderedEnumerable<TElement>，其元素按键排序。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 为 null。
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector);
        //
        // 摘要:
        //     使用指定的比较器按升序对序列的元素排序。
        //
        // 参数:
        //   source:
        //     一个要排序的值序列。
        //
        //   keySelector:
        //     用于从元素中提取键的函数。
        //
        //   comparer:
        //     一个用于比较键的 System.Collections.Generic.IComparer<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        // 返回结果:
        //     一个 System.Linq.IOrderedEnumerable<TElement>，其元素按键排序。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 为 null。
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer);
        //
        // 摘要:
        //     根据键按降序对序列的元素排序。
        //
        // 参数:
        //   source:
        //     一个要排序的值序列。
        //
        //   keySelector:
        //     用于从元素中提取键的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        // 返回结果:
        //     一个 System.Linq.IOrderedEnumerable<TElement>，将根据某个键按降序对其元素进行排序。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 为 null。
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector);
        //
        // 摘要:
        //     使用指定的比较器按降序对序列的元素排序。
        //
        // 参数:
        //   source:
        //     一个要排序的值序列。
        //
        //   keySelector:
        //     用于从元素中提取键的函数。
        //
        //   comparer:
        //     一个用于比较键的 System.Collections.Generic.IComparer<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        // 返回结果:
        //     一个 System.Linq.IOrderedEnumerable<TElement>，将根据某个键按降序对其元素进行排序。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 为 null。
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer);
        //
        // 摘要:
        //     生成指定范围内的整数的序列。
        //
        // 参数:
        //   start:
        //     序列中第一个整数的值。
        //
        //   count:
        //     要生成的顺序整数的数目。
        //
        // 返回结果:
        //     C# 中的 IEnumerable<Int32> 或 Visual Basic 中包含某个范围内的顺序整数的 IEnumerable(Of Int32)。
        //
        // 异常:
        //   System.ArgumentOutOfRangeException:
        //     count 小于 0。 - 或 - start + count -1 大于 System.Int32.MaxValue。
        public static IEnumerable<int> Range(int start, int count);
        //
        // 摘要:
        //     生成包含一个重复值的序列。
        //
        // 参数:
        //   element:
        //     要重复的值。
        //
        //   count:
        //     在生成序列中重复该值的次数。
        //
        // 类型参数:
        //   TResult:
        //     要在结果序列中重复的值的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，包含一个重复值。
        //
        // 异常:
        //   System.ArgumentOutOfRangeException:
        //     count 小于 0。
        public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count);
        //
        // 摘要:
        //     反转序列中元素的顺序。
        //
        // 参数:
        //   source:
        //     要反转的值序列。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     一个序列，其元素以相反顺序对应于输入序列的元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static IEnumerable<TSource> Reverse<TSource>(this IEnumerable<TSource> source);
        //
        // 摘要:
        //     通过合并元素的索引将序列的每个元素投影到新表中。
        //
        // 参数:
        //   source:
        //     一个值序列，要对该序列调用转换函数。
        //
        //   selector:
        //     一个应用于每个源元素的转换函数；函数的第二个参数表示源元素的索引。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TResult:
        //     selector 返回的值的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，其元素为对 source 的每个元素调用转换函数的结果。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector);
        //
        // 摘要:
        //     将序列中的每个元素投影到新表中。
        //
        // 参数:
        //   source:
        //     一个值序列，要对该序列调用转换函数。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TResult:
        //     selector 返回的值的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，其元素为对 source 的每个元素调用转换函数的结果。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector);
        //
        // 摘要:
        //     将序列的每个元素投影到 System.Collections.Generic.IEnumerable<T> 并将结果序列合并为一个序列。
        //
        // 参数:
        //   source:
        //     一个要投影的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TResult:
        //     selector 返回的序列元素的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，其元素是对输入序列的每个元素调用一对多转换函数的结果。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector);
        //
        // 摘要:
        //     将序列的每个元素投影到 System.Collections.Generic.IEnumerable<T>，并将结果序列合并为一个序列。每个源元素的索引用于该元素的投影表。
        //
        // 参数:
        //   source:
        //     一个要投影的值序列。
        //
        //   selector:
        //     一个应用于每个源元素的转换函数；函数的第二个参数表示源元素的索引。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TResult:
        //     selector 返回的序列元素的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，其元素是对输入序列的每个元素调用一对多转换函数的结果。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector);
        //
        // 摘要:
        //     将序列的每个元素投影到 System.Collections.Generic.IEnumerable<T>，并将结果序列合并为一个序列，并对其中每个元素调用结果选择器函数。
        //
        // 参数:
        //   source:
        //     一个要投影的值序列。
        //
        //   collectionSelector:
        //     一个应用于输入序列的每个元素的转换函数。
        //
        //   resultSelector:
        //     一个应用于中间序列的每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TCollection:
        //     collectionSelector 收集的中间元素的类型。
        //
        //   TResult:
        //     结果序列的元素的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，其元素是对 source 的每个元素调用一对多转换函数
        //     collectionSelector，然后将那些序列元素中的每一个及其相应的源元素映射为结果元素的结果。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 collectionSelector 或 resultSelector 为 null。
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector);
        //
        // 摘要:
        //     将序列的每个元素投影到 System.Collections.Generic.IEnumerable<T>，并将结果序列合并为一个序列，并对其中每个元素调用结果选择器函数。每个源元素的索引用于该元素的中间投影表。
        //
        // 参数:
        //   source:
        //     一个要投影的值序列。
        //
        //   collectionSelector:
        //     一个应用于每个源元素的转换函数；函数的第二个参数表示源元素的索引。
        //
        //   resultSelector:
        //     一个应用于中间序列的每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TCollection:
        //     collectionSelector 收集的中间元素的类型。
        //
        //   TResult:
        //     结果序列的元素的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，其元素是对 source 的每个元素调用一对多转换函数
        //     collectionSelector，然后将那些序列元素中的每一个及其相应的源元素映射为结果元素的结果。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 collectionSelector 或 resultSelector 为 null。
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector);
        //
        // 摘要:
        //     通过使用相应类型的默认相等比较器对序列的元素进行比较，以确定两个序列是否相等。
        //
        // 参数:
        //   first:
        //     一个用于比较 second 的 System.Collections.Generic.IEnumerable<T>。
        //
        //   second:
        //     一个 System.Collections.Generic.IEnumerable<T>，用于与第一个序列进行比较。
        //
        // 类型参数:
        //   TSource:
        //     输入序列中的元素的类型。
        //
        // 返回结果:
        //     如果根据相应类型的默认相等比较器，两个源序列的长度相等，且其相应元素相等，则为 true；否则为 false。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     first 或 second 为 null。
        public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second);
        //
        // 摘要:
        //     使用指定的 System.Collections.Generic.IEqualityComparer<T> 对两个序列的元素进行比较，以确定序列是否相等。
        //
        // 参数:
        //   first:
        //     一个用于比较 second 的 System.Collections.Generic.IEnumerable<T>。
        //
        //   second:
        //     一个 System.Collections.Generic.IEnumerable<T>，用于与第一个序列进行比较。
        //
        //   comparer:
        //     一个用于比较元素的 System.Collections.Generic.IEqualityComparer<T>。
        //
        // 类型参数:
        //   TSource:
        //     输入序列中的元素的类型。
        //
        // 返回结果:
        //     如果根据 comparer，两个源序列的长度相等，且其相应元素相等，则为 true；否则为 false。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     first 或 second 为 null。
        public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer);
        //
        // 摘要:
        //     返回序列的唯一元素；如果该序列并非恰好包含一个元素，则会引发异常。
        //
        // 参数:
        //   source:
        //     一个 System.Collections.Generic.IEnumerable<T>，用于返回单个元素。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     输入序列的单个元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     输入序列包含多个元素。 - 或 - 输入序列为空。
        public static TSource Single<TSource>(this IEnumerable<TSource> source);
        //
        // 摘要:
        //     返回序列中满足指定条件的唯一元素；如果有多个这样的元素存在，则会引发异常。
        //
        // 参数:
        //   source:
        //     一个 System.Collections.Generic.IEnumerable<T>，用于从中返回单个元素。
        //
        //   predicate:
        //     用于测试元素是否满足条件的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     输入序列中满足条件的单个元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 predicate 为 null。
        //
        //   System.InvalidOperationException:
        //     没有元素满足 predicate 中的条件。 - 或 - 多个元素满足 predicate 中的条件。 - 或 - 源序列为空。
        public static TSource Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
        //
        // 摘要:
        //     返回序列中的唯一元素；如果该序列为空，则返回默认值；如果该序列包含多个元素，此方法将引发异常。
        //
        // 参数:
        //   source:
        //     一个 System.Collections.Generic.IEnumerable<T>，用于返回单个元素。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     返回输入序列的单个元素；如果序列不包含任何元素，则返回 default(TSource)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.InvalidOperationException:
        //     输入序列包含多个元素。
        public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source);
        //
        // 摘要:
        //     返回序列中满足指定条件的唯一元素；如果这类元素不存在，则返回默认值；如果有多个元素满足该条件，此方法将引发异常。
        //
        // 参数:
        //   source:
        //     一个 System.Collections.Generic.IEnumerable<T>，用于从中返回单个元素。
        //
        //   predicate:
        //     用于测试元素是否满足条件的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     如果未找到这样的元素，则返回输入序列中满足条件的单个元素或 default (TSource)。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 predicate 为 null。
        //
        //   System.InvalidOperationException:
        //     多个元素满足 predicate 中的条件。
        public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
        //
        // 摘要:
        //     跳过序列中指定数量的元素，然后返回剩余的元素。
        //
        // 参数:
        //   source:
        //     一个 System.Collections.Generic.IEnumerable<T>，用于从中返回元素。
        //
        //   count:
        //     返回剩余元素前要跳过的元素数量。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，包含输入序列中指定索引后出现的元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static IEnumerable<TSource> Skip<TSource>(this IEnumerable<TSource> source, int count);
        //
        // 摘要:
        //     只要满足指定的条件，就跳过序列中的元素，然后返回剩余元素。
        //
        // 参数:
        //   source:
        //     一个 System.Collections.Generic.IEnumerable<T>，用于从中返回元素。
        //
        //   predicate:
        //     用于测试每个元素是否满足条件的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，包含输入序列中的元素，该输入序列从线性系列中没有通过 predicate
        //     指定测试的第一个元素开始。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 predicate 为 null。
        public static IEnumerable<TSource> SkipWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
        //
        // 摘要:
        //     只要满足指定的条件，就跳过序列中的元素，然后返回剩余元素。将在谓词函数的逻辑中使用元素的索引。
        //
        // 参数:
        //   source:
        //     一个 System.Collections.Generic.IEnumerable<T>，用于从中返回元素。
        //
        //   predicate:
        //     用于测试每个源元素是否满足条件的函数；该函数的第二个参数表示源元素的索引。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，包含输入序列中的元素，该输入序列从线性系列中没有通过 predicate
        //     指定测试的第一个元素开始。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 predicate 为 null。
        public static IEnumerable<TSource> SkipWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate);
        //
        // 摘要:
        //     计算可以为 null 的 System.Decimal 值序列之和。
        //
        // 参数:
        //   source:
        //     要计算和的可以为 null 的 System.Decimal 值序列。
        //
        // 返回结果:
        //     序列值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.OverflowException:
        //     和大于 System.Decimal.MaxValue。
        public static decimal? Sum(this IEnumerable<decimal?> source);
        //
        // 摘要:
        //     计算 System.Decimal 值序列之和。
        //
        // 参数:
        //   source:
        //     一个要计算和的 System.Decimal 值序列。
        //
        // 返回结果:
        //     序列值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.OverflowException:
        //     和大于 System.Decimal.MaxValue。
        public static decimal Sum(this IEnumerable<decimal> source);
        //
        // 摘要:
        //     计算可以为 null 的 System.Double 值序列之和。
        //
        // 参数:
        //   source:
        //     要计算和的可以为 null 的 System.Double 值序列。
        //
        // 返回结果:
        //     序列值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static double? Sum(this IEnumerable<double?> source);
        //
        // 摘要:
        //     计算 System.Double 值序列之和。
        //
        // 参数:
        //   source:
        //     一个要计算和的 System.Double 值序列。
        //
        // 返回结果:
        //     序列值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static double Sum(this IEnumerable<double> source);
        //
        // 摘要:
        //     计算可以为 null 的 System.Single 值序列之和。
        //
        // 参数:
        //   source:
        //     要计算和的可以为 null 的 System.Single 值序列。
        //
        // 返回结果:
        //     序列值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static float? Sum(this IEnumerable<float?> source);
        //
        // 摘要:
        //     计算 System.Single 值序列之和。
        //
        // 参数:
        //   source:
        //     一个要计算和的 System.Single 值序列。
        //
        // 返回结果:
        //     序列值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static float Sum(this IEnumerable<float> source);
        //
        // 摘要:
        //     计算可以为 null 的 System.Int32 值序列之和。
        //
        // 参数:
        //   source:
        //     要计算和的可以为 null 的 System.Int32 值序列。
        //
        // 返回结果:
        //     序列值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.OverflowException:
        //     和大于 System.Int32.MaxValue。
        public static int? Sum(this IEnumerable<int?> source);
        //
        // 摘要:
        //     计算 System.Int32 值序列之和。
        //
        // 参数:
        //   source:
        //     一个要计算和的 System.Int32 值序列。
        //
        // 返回结果:
        //     序列值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.OverflowException:
        //     和大于 System.Int32.MaxValue。
        public static int Sum(this IEnumerable<int> source);
        //
        // 摘要:
        //     计算可以为 null 的 System.Int64 值序列之和。
        //
        // 参数:
        //   source:
        //     要计算和的可以为 null 的 System.Int64 值序列。
        //
        // 返回结果:
        //     序列值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.OverflowException:
        //     和大于 System.Int64.MaxValue。
        public static long? Sum(this IEnumerable<long?> source);
        //
        // 摘要:
        //     计算 System.Int64 值序列之和。
        //
        // 参数:
        //   source:
        //     一个要计算和的 System.Int64 值序列。
        //
        // 返回结果:
        //     序列值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        //
        //   System.OverflowException:
        //     和大于 System.Int64.MaxValue。
        public static long Sum(this IEnumerable<long> source);
        //
        // 摘要:
        //     计算可以为 null 的 System.Decimal 值序列的和，这些值是通过对输入序列中的每个元素调用转换函数得来的。
        //
        // 参数:
        //   source:
        //     用于计算和的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     投影值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.OverflowException:
        //     和大于 System.Decimal.MaxValue。
        public static decimal? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector);
        //
        // 摘要:
        //     计算 System.Decimal 值序列的和，这些值是通过对输入序列中的每个元素调用转换函数得来的。
        //
        // 参数:
        //   source:
        //     用于计算和的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     投影值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.OverflowException:
        //     和大于 System.Decimal.MaxValue。
        public static decimal Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector);
        //
        // 摘要:
        //     计算可以为 null 的 System.Double 值序列的和，这些值是通过对输入序列中的每个元素调用转换函数得来的。
        //
        // 参数:
        //   source:
        //     用于计算和的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     投影值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static double? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector);
        //
        // 摘要:
        //     计算 System.Double 值序列的和，这些值是通过对输入序列中的每个元素调用转换函数得来的。
        //
        // 参数:
        //   source:
        //     用于计算和的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     投影值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static double Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector);
        //
        // 摘要:
        //     计算可以为 null 的 System.Single 值序列的和，这些值是通过对输入序列中的每个元素调用转换函数得来的。
        //
        // 参数:
        //   source:
        //     用于计算和的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     投影值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static float? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector);
        //
        // 摘要:
        //     计算 System.Single 值序列的和，这些值是通过对输入序列中的每个元素调用转换函数得来的。
        //
        // 参数:
        //   source:
        //     用于计算和的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     投影值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        public static float Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector);
        //
        // 摘要:
        //     计算可以为 null 的 System.Int32 值序列的和，这些值是通过对输入序列中的每个元素调用转换函数得来的。
        //
        // 参数:
        //   source:
        //     用于计算和的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     投影值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.OverflowException:
        //     和大于 System.Int32.MaxValue。
        public static int? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector);
        //
        // 摘要:
        //     计算 System.Int32 值序列的和，这些值是通过对输入序列中的每个元素调用转换函数得来的。
        //
        // 参数:
        //   source:
        //     用于计算和的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     投影值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.OverflowException:
        //     和大于 System.Int32.MaxValue。
        public static int Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector);
        //
        // 摘要:
        //     计算可以为 null 的 System.Int64 值序列的和，这些值是通过对输入序列中的每个元素调用转换函数得来的。
        //
        // 参数:
        //   source:
        //     用于计算和的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     投影值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.OverflowException:
        //     和大于 System.Int64.MaxValue。
        public static long? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector);
        //
        // 摘要:
        //     计算 System.Int64 值序列的和，这些值是通过对输入序列中的每个元素调用转换函数得来的。
        //
        // 参数:
        //   source:
        //     用于计算和的值序列。
        //
        //   selector:
        //     应用于每个元素的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     投影值之和。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 selector 为 null。
        //
        //   System.OverflowException:
        //     和大于 System.Int64.MaxValue。
        public static long Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector);
        //
        // 摘要:
        //     从序列的开头返回指定数量的连续元素。
        //
        // 参数:
        //   source:
        //     要从其返回元素的序列。
        //
        //   count:
        //     要返回的元素数量。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，包含输入序列开头的指定数量的元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> source, int count);
        //
        // 摘要:
        //     只要满足指定的条件，就会返回序列的元素。
        //
        // 参数:
        //   source:
        //     要从其返回元素的序列。
        //
        //   predicate:
        //     用于测试每个元素是否满足条件的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，包含输入序列中出现在测试不再能够通过的元素之前的元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 predicate 为 null。
        public static IEnumerable<TSource> TakeWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
        //
        // 摘要:
        //     只要满足指定的条件，就会返回序列的元素。将在谓词函数的逻辑中使用元素的索引。
        //
        // 参数:
        //   source:
        //     要从其返回元素的序列。
        //
        //   predicate:
        //     用于测试每个源元素是否满足条件的函数；该函数的第二个参数表示源元素的索引。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，包含输入序列中出现在测试不再能够通过的元素之前的元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 predicate 为 null。
        public static IEnumerable<TSource> TakeWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate);
        //
        // 摘要:
        //     根据某个键按升序对序列中的元素执行后续排序。
        //
        // 参数:
        //   source:
        //     一个 System.Linq.IOrderedEnumerable<TElement>，包含要排序的元素。
        //
        //   keySelector:
        //     用于从每个元素中提取键的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        // 返回结果:
        //     一个 System.Linq.IOrderedEnumerable<TElement>，其元素按键排序。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 为 null。
        public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector);
        //
        // 摘要:
        //     使用指定的比较器按升序对序列中的元素执行后续排序。
        //
        // 参数:
        //   source:
        //     一个 System.Linq.IOrderedEnumerable<TElement>，包含要排序的元素。
        //
        //   keySelector:
        //     用于从每个元素中提取键的函数。
        //
        //   comparer:
        //     一个用于比较键的 System.Collections.Generic.IComparer<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        // 返回结果:
        //     一个 System.Linq.IOrderedEnumerable<TElement>，其元素按键排序。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 为 null。
        public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer);
        //
        // 摘要:
        //     根据某个键按降序对序列中的元素执行后续排序。
        //
        // 参数:
        //   source:
        //     一个 System.Linq.IOrderedEnumerable<TElement>，包含要排序的元素。
        //
        //   keySelector:
        //     用于从每个元素中提取键的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        // 返回结果:
        //     一个 System.Linq.IOrderedEnumerable<TElement>，将根据某个键按降序对其元素进行排序。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 为 null。
        public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector);
        //
        // 摘要:
        //     使用指定的比较器按降序对序列中的元素执行后续排序。
        //
        // 参数:
        //   source:
        //     一个 System.Linq.IOrderedEnumerable<TElement>，包含要排序的元素。
        //
        //   keySelector:
        //     用于从每个元素中提取键的函数。
        //
        //   comparer:
        //     一个用于比较键的 System.Collections.Generic.IComparer<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        // 返回结果:
        //     一个 System.Linq.IOrderedEnumerable<TElement>，将根据某个键按降序对其元素进行排序。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 为 null。
        public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer);
        //
        // 摘要:
        //     从 System.Collections.Generic.IEnumerable<T> 创建一个数组。
        //
        // 参数:
        //   source:
        //     要从其创建数组的 System.Collections.Generic.IEnumerable<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     一个包含输入序列中的元素的数组。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source);
        //
        // 摘要:
        //     根据指定的键选择器函数，从 System.Collections.Generic.IEnumerable<T> 创建一个 System.Collections.Generic.Dictionary<TKey,TValue>。
        //
        // 参数:
        //   source:
        //     一个 System.Collections.Generic.IEnumerable<T>，将从它创建一个 System.Collections.Generic.Dictionary<TKey,TValue>。
        //
        //   keySelector:
        //     用于从每个元素中提取键的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        // 返回结果:
        //     一个包含键和值的 System.Collections.Generic.Dictionary<TKey,TValue>。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 为 null。 - 或 - keySelector 产生了一个 null 键。
        //
        //   System.ArgumentException:
        //     keySelector 为两个元素产生了重复键。
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector);
        //
        // 摘要:
        //     根据指定的键选择器和元素选择器函数，从 System.Collections.Generic.IEnumerable<T> 创建一个 System.Collections.Generic.Dictionary<TKey,TValue>。
        //
        // 参数:
        //   source:
        //     一个 System.Collections.Generic.IEnumerable<T>，将从它创建一个 System.Collections.Generic.Dictionary<TKey,TValue>。
        //
        //   keySelector:
        //     用于从每个元素中提取键的函数。
        //
        //   elementSelector:
        //     用于从每个元素产生结果元素值的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        //   TElement:
        //     elementSelector 返回的值的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.Dictionary<TKey,TValue>，包含从输入序列中选择的类型为 TElement
        //     的值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 或 elementSelector 为 null。 - 或 - keySelector 产生了一个 null
        //     键。
        //
        //   System.ArgumentException:
        //     keySelector 为两个元素产生了重复键。
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector);
        //
        // 摘要:
        //     根据指定的键选择器函数和键比较器，从 System.Collections.Generic.IEnumerable<T> 创建一个 System.Collections.Generic.Dictionary<TKey,TValue>。
        //
        // 参数:
        //   source:
        //     一个 System.Collections.Generic.IEnumerable<T>，将从它创建一个 System.Collections.Generic.Dictionary<TKey,TValue>。
        //
        //   keySelector:
        //     用于从每个元素中提取键的函数。
        //
        //   comparer:
        //     一个用于对键进行比较的 System.Collections.Generic.IEqualityComparer<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        // 返回结果:
        //     一个包含键和值的 System.Collections.Generic.Dictionary<TKey,TValue>。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 为 null。 - 或 - keySelector 产生了一个 null 键。
        //
        //   System.ArgumentException:
        //     keySelector 为两个元素产生了重复键。
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer);
        //
        // 摘要:
        //     根据指定的键选择器函数、比较器和元素选择器函数从 System.Collections.Generic.IEnumerable<T> 创建一个 System.Collections.Generic.Dictionary<TKey,TValue>。
        //
        // 参数:
        //   source:
        //     一个 System.Collections.Generic.IEnumerable<T>，将从它创建一个 System.Collections.Generic.Dictionary<TKey,TValue>。
        //
        //   keySelector:
        //     用于从每个元素中提取键的函数。
        //
        //   elementSelector:
        //     用于从每个元素产生结果元素值的转换函数。
        //
        //   comparer:
        //     一个用于对键进行比较的 System.Collections.Generic.IEqualityComparer<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        //   TElement:
        //     elementSelector 返回的值的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.Dictionary<TKey,TValue>，包含从输入序列中选择的类型为 TElement
        //     的值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 或 elementSelector 为 null。 - 或 - keySelector 产生了一个 null
        //     键。
        //
        //   System.ArgumentException:
        //     keySelector 为两个元素产生了重复键。
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer);
        //
        // 摘要:
        //     从 System.Collections.Generic.IEnumerable<T> 创建一个 System.Collections.Generic.List<T>。
        //
        // 参数:
        //   source:
        //     要从其创建 System.Collections.Generic.List<T> 的 System.Collections.Generic.IEnumerable<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     一个包含输入序列中元素的 System.Collections.Generic.List<T>。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 为 null。
        public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source);
        //
        // 摘要:
        //     根据指定的键选择器函数，从 System.Collections.Generic.IEnumerable<T> 创建一个 System.Linq.Lookup<TKey,TElement>。
        //
        // 参数:
        //   source:
        //     要从其创建 System.Linq.Lookup<TKey,TElement> 的 System.Collections.Generic.IEnumerable<T>。
        //
        //   keySelector:
        //     用于从每个元素中提取键的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        // 返回结果:
        //     一个包含键和值的 System.Linq.Lookup<TKey,TElement>。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 为 null。
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector);
        //
        // 摘要:
        //     根据指定的键选择器和元素选择器函数，从 System.Collections.Generic.IEnumerable<T> 创建一个 System.Linq.Lookup<TKey,TElement>。
        //
        // 参数:
        //   source:
        //     要从其创建 System.Linq.Lookup<TKey,TElement> 的 System.Collections.Generic.IEnumerable<T>。
        //
        //   keySelector:
        //     用于从每个元素中提取键的函数。
        //
        //   elementSelector:
        //     用于从每个元素产生结果元素值的转换函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        //   TElement:
        //     elementSelector 返回的值的类型。
        //
        // 返回结果:
        //     一个 System.Linq.Lookup<TKey,TElement>，包含从输入序列中选择的类型为 TElement 的值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 或 elementSelector 为 null。
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector);
        //
        // 摘要:
        //     根据指定的键选择器函数和键比较器，从 System.Collections.Generic.IEnumerable<T> 创建一个 System.Linq.Lookup<TKey,TElement>。
        //
        // 参数:
        //   source:
        //     要从其创建 System.Linq.Lookup<TKey,TElement> 的 System.Collections.Generic.IEnumerable<T>。
        //
        //   keySelector:
        //     用于从每个元素中提取键的函数。
        //
        //   comparer:
        //     一个用于对键进行比较的 System.Collections.Generic.IEqualityComparer<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        // 返回结果:
        //     一个包含键和值的 System.Linq.Lookup<TKey,TElement>。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 为 null。
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer);
        //
        // 摘要:
        //     根据指定的键选择器函数、比较器和元素选择器函数，从 System.Collections.Generic.IEnumerable<T> 创建一个
        //     System.Linq.Lookup<TKey,TElement>。
        //
        // 参数:
        //   source:
        //     要从其创建 System.Linq.Lookup<TKey,TElement> 的 System.Collections.Generic.IEnumerable<T>。
        //
        //   keySelector:
        //     用于从每个元素中提取键的函数。
        //
        //   elementSelector:
        //     用于从每个元素产生结果元素值的转换函数。
        //
        //   comparer:
        //     一个用于对键进行比较的 System.Collections.Generic.IEqualityComparer<T>。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        //   TKey:
        //     keySelector 返回的键的类型。
        //
        //   TElement:
        //     elementSelector 返回的值的类型。
        //
        // 返回结果:
        //     一个 System.Linq.Lookup<TKey,TElement>，包含从输入序列中选择的类型为 TElement 的值。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 keySelector 或 elementSelector 为 null。
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer);
        //
        // 摘要:
        //     通过使用默认的相等比较器生成两个序列的并集。
        //
        // 参数:
        //   first:
        //     一个 System.Collections.Generic.IEnumerable<T>，它的非重复元素构成联合的第一个集。
        //
        //   second:
        //     一个 System.Collections.Generic.IEnumerable<T>，它的非重复元素构成联合的第二个集。
        //
        // 类型参数:
        //   TSource:
        //     输入序列中的元素的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，包含两个输入序列中的非重复元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     first 或 second 为 null。
        public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second);
        //
        // 摘要:
        //     通过使用指定的 System.Collections.Generic.IEqualityComparer<T> 生成两个序列的并集。
        //
        // 参数:
        //   first:
        //     一个 System.Collections.Generic.IEnumerable<T>，它的非重复元素构成联合的第一个集。
        //
        //   second:
        //     一个 System.Collections.Generic.IEnumerable<T>，它的非重复元素构成联合的第二个集。
        //
        //   comparer:
        //     用于对值进行比较的 System.Collections.Generic.IEqualityComparer<T>。
        //
        // 类型参数:
        //   TSource:
        //     输入序列中的元素的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，包含两个输入序列中的非重复元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     first 或 second 为 null。
        public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer);
        //
        // 摘要:
        //     基于谓词筛选值序列。
        //
        // 参数:
        //   source:
        //     要筛选的 System.Collections.Generic.IEnumerable<T>。
        //
        //   predicate:
        //     用于测试每个元素是否满足条件的函数。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，包含输入序列中满足条件的元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 predicate 为 null。
        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
        //
        // 摘要:
        //     基于谓词筛选值序列。将在谓词函数的逻辑中使用每个元素的索引。
        //
        // 参数:
        //   source:
        //     要筛选的 System.Collections.Generic.IEnumerable<T>。
        //
        //   predicate:
        //     用于测试每个源元素是否满足条件的函数；该函数的第二个参数表示源元素的索引。
        //
        // 类型参数:
        //   TSource:
        //     source 中的元素的类型。
        //
        // 返回结果:
        //     一个 System.Collections.Generic.IEnumerable<T>，包含输入序列中满足条件的元素。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     source 或 predicate 为 null。
        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate);
    }
}
