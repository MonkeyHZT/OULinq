//
//  NSArray+OU.h
//  OULinqDemo
//
//  Created by HouZhiTong on 15/11/16.
//  Copyright © 2015年 com.houzhitong. All rights reserved.

#import <Foundation/Foundation.h>
/**
 *  传入一个参数.返回一个对比的BOOL值
 *
 *  @return 对比结果
 */
typedef BOOL (^BoolBlock)(id parameter);
/**
 *  @brief 传入一个id类型参数.返回一个id类型对象
 *
 *  @return 返回一个id类型对象
 */
typedef id (^IDBlock)(id parameter);

@interface NSArray (OU)

/**
*  确定序列中的所有元素是否满足条件
*
*  @param boolBlock block表达式.用于确定元素是否满足条件
*
*  @return YES表示全部满足条件.NO表示有部分或者全部不满足
*/
- (BOOL)all:(BoolBlock)boolBlock;

/**
*  检测集合中是否元素(不等于nil并且内容个数大于0)
*
*  @return YES表示有元素.NO表示无
*/
- (BOOL)any;


/**
 *  检测集合中是否有任意一个元素满足条件
 *
 *  @return YES表示至少有一个满足条件.NO表示全部不满足
 */
- (BOOL)any:(BoolBlock)boolBlock;
/**
 *  @author Hzt, 2016-12-29 14:12:05
 *
 *  @brief 返回第一个满足条件的对象.如果没有任何满足的会抛出异常
 *
 *  @return 第一个满足条件的对象.没有则抛异常
 */
- (id)first:(BoolBlock)boolBlock;
/**
 *  @author Hzt, 2016-12-29 14:12:12
 *
 *  @brief 返回第一个满足条件的对象.如果没有找到则返回Null
 *
 *  @return 第一个满足条件的对象.没有则返回nil
 */
- (id)firstOrNull:(BoolBlock)boolBlock;
/**
 *  @author Hzt, 2016-12-29 14:12:12
 *
 *  @brief 返回所有满足表达式条件的对象
 *
 *  @return 所有满足条件的对象集合.如果没有找到则count为0
 */
- (NSArray*)where:(BoolBlock)boolBlock;

//public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value);

/**
 *  @brief 当前集合是否包含指定内容对象
 *
 *  @return 是否包含对象
 */
-(BOOL)containsWithObjecte:(id)object;
/**
 *  @brief 从startIndex开始截取到末尾
 *
 *  @param startIndex 开始的位置
 *
 *  @return 返回一个截取到的arr
 */
-(NSArray *)arrayWithStartIndex:(NSInteger)startIndex;
/**
 *  @brief 从startIndex截取到endIndex位置
 *
 *  @param startIndex 开始的位置
 *  @param endIndex   结束的位置
 *
 *  @return 返回一个截取到的arr
 */
-(NSArray *)ArrayWithStartIndex:(NSInteger)startIndex endIndex:(NSInteger)endIndex;
/**
 *  @brief 从startIndex开始,截取length个长度的对象
 *
 *  @param startIndex 开始的位置
 *  @param length     要截取的长度
 *
 *  @return 返回一个截取到的arr
 */
-(NSArray *)arrayWithStartIndex:(NSInteger)startIndex length:(NSInteger)length;
/**
 *  @brief 遍历自身所有对象.对每个对象都执行一次block并返回一个新的id类型对象
 *
 *  @return 新的结果集对象
 */
-(NSArray *)convertToOtherObjectWithBlock:(IDBlock)block;

@end
