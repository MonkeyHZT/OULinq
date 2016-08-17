//
//  NSArray+OU.m
//  OULinqDemo
//
//  Created by HouZhiTong on 15/11/16.
//  Copyright © 2015年 com.houzhitong. All rights reserved.
//

#import "NSArray+OU.h"

@implementation NSArray (OU)

- (BOOL)all:(BoolBlock)boolBlock
{
    NSAssert(boolBlock, @"未设置参数");
    for (int i = 0; i < [self count]; i++) {
        if (!boolBlock(self[i])) {
            return NO;
        }
    }
    return YES;
}

- (BOOL)any
{
    return [self count] > 0;
}

- (BOOL)any:(BoolBlock)boolBlock
{
    NSAssert(boolBlock, @"未设置参数");
    for (int i = 0; i < [self count]; i++) {
        if (boolBlock(self[i])) {
            return YES;
        }
    }
    return NO;
}

- (id)first:(BoolBlock)boolBlock
{
    NSAssert(boolBlock, @"未设置参数");
    id obj = [self firstOrNull:boolBlock];
    if (!obj) {
        [NSException raise:@"没有找到任何满足条件的对象"
                    format:@"没有找到任何满足条件的对象"];
    }
    return obj;
}

- (id)firstOrNull:(BoolBlock)boolBlock
{
    NSAssert(boolBlock, @"未设置参数");
    for (int i = 0; i < [self count]; i++) {
        id item = [self objectAtIndex:i];
        if (boolBlock(item)) {
            return item;
        }
    }
    return nil;
}

- (NSArray*)where:(BoolBlock)boolBlock
{
    NSAssert(boolBlock, @"未设置参数");
    NSMutableArray* result = [NSMutableArray array];
    for (int i = 0; i < [self count]; i++) {
        id item = [self objectAtIndex:i];
        if (boolBlock(item)) {
            [result addObject:item];
        }
    }
    return result.copy;
}

- (BOOL)containsWithObjecte:(id)object
{
    return [self containsObject:object];
}

- (NSArray*)arrayWithStartIndex:(NSInteger)startIndex
{
    NSInteger endIndex = self.count - startIndex;
    return [self arrayWithStartIndex:startIndex endIndex:endIndex];
}

- (NSArray*)arrayWithStartIndex:(NSInteger)startIndex endIndex:(NSInteger)endIndex
{
    NSInteger length = endIndex - startIndex;
    return [self arrayWithStartIndex:startIndex length:length];
}

- (NSArray*)arrayWithStartIndex:(NSInteger)startIndex length:(NSInteger)length
{
    NSAssert(startIndex >= 0 && startIndex < self.count, @"startIndex越界");
    NSAssert(length >= 0 && (startIndex + length) <= self.count, @"length越界");
    NSMutableArray* resultArrayM = [NSMutableArray arrayWithCapacity:length];
    for (NSInteger i = startIndex; i < (startIndex + length); i++) {
        id item = self[i];
        [resultArrayM addObject:item];
    }
    return resultArrayM.copy;
}

-(NSArray *)convertToOtherObjectWithBlock:(IDBlock)block{
    NSAssert(block, @"未设置参数");
    NSMutableArray *resultArrayM = [NSMutableArray arrayWithCapacity:self.count];
    for (int i = 0; i<self.count; i++) {
        id item = self[i];
        id resultObj = block(item);
        [resultArrayM addObject:resultObj];
    }
    return resultArrayM;
}

@end
