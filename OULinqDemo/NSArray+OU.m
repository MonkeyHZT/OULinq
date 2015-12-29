//
//  NSArray+OU.m
//  OULinqDemo
//
//  Created by HouZhiTong on 15/11/16.
//  Copyright © 2015年 com.houzhitong. All rights reserved.
//

#import "NSArray+OU.h"

@implementation NSArray (OU)

- (BOOL)All:(BoolBlock)boolBlock {
  for (int i = 0; i < [self count]; i++) {
    if (!boolBlock(self[i])) {
      return NO;
    }
  }
  return YES;
}

- (BOOL)Any {
  return [self count] > 0;
}

- (BOOL)Any:(BoolBlock)boolBlock {
  for (int i = 0; i < [self count]; i++) {
    if (boolBlock(self[i])) {
      return YES;
    }
  }
  return NO;
}

- (id)First:(BoolBlock)boolBlock {
  id obj = [self FirstOrNull:boolBlock];
  if (!obj) {
    [NSException raise:@"没有找到任何满足条件的对象"
                format:@"没有找到任何满足条件的对象"];
  }
  return obj;
}
/**
 *  @author Hzt, 2016-12-29 14:12:12
 *
 *  @brief 返回第一个满足条件的对象.如果没有找到则返回Null
 *
 *  @param boolBlock block表达式.表示是否满足条件
 *
 *  @return 第一个满足条件的对象.没有则返回nil
 */
- (id)FirstOrNull:(BoolBlock)boolBlock {
  for (int i = 0; i < [self count]; i++) {
    id item = [self objectAtIndex:i];
    if (boolBlock(item)) {
      return item;
    }
  }
  return nil;
}
/**
 *  @author Hzt, 2016-12-29 14:12:12
 *
 *  @brief 返回所有满足表达式条件的对象
 *
 *  @param boolBlock block表达式.表示是否满足条件
 *
 *  @return 所有满足条件的对象集合.如果没有找到则count为0
 */
- (NSArray *)Where:(BoolBlock)boolBlock {
  NSMutableArray *result = [NSMutableArray array];
  for (int i = 0; i < [self count]; i++) {
    id item = [self objectAtIndex:i];
    if (boolBlock(item)) {
      [result addObject:item];
    }
  }
  return result.copy;
}
@end
