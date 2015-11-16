//
//  NSArray+OU.h
//  OULinqDemo
//
//  Created by HouZhiTong on 15/11/16.
//  Copyright © 2015年 com.houzhitong. All rights reserved.
//

#import <Foundation/Foundation.h>
/**
 *  传入一个参数.返回一个对比的BOOL值
 *
 *  @param parameter 遍历集合时的具体对象
 *
 *  @return 对比结果
 */
typedef BOOL (^BoolBlock)(id parameter);

@interface NSArray (OU)

/**
*  确定序列中的所有元素是否满足条件
*
*  @param boolBlock block表达式.用于确定元素是否满足条件
*
*  @return YES表示全部满足条件.NO表示有部分或者全部不满足
*/
- (BOOL)All:(BoolBlock)boolBlock;

/**
*  检测集合中是否元素(不等于nil并且内容个数大于0)
*
*  @return YES表示有元素.NO表示无
*/
- (BOOL)Any;

/*
 
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
 */

@end
