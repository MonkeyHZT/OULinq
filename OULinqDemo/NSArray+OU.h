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

/**
 *  检测集合中是否有任意一个元素满足条件
 *
 *  @param boolBlock block表达式.表示是否满足条件
 *
 *  @return YES表示至少有一个满足条件.NO表示全部不满足
 */
-(BOOL)Any:(BoolBlock)boolBlock;

@end
