//
//  NSArray+OU.m
//  OULinqDemo
//
//  Created by HouZhiTong on 15/11/16.
//  Copyright © 2015年 com.houzhitong. All rights reserved.
//

#define forEach(max) for (int i = 0; i < max; i++)
#define forEachSelfCount forEach(self.count)
#import "NSArray+OU.h"

@implementation NSArray (OU)

- (BOOL)all:(BoolBlock)boolBlock
{
    NSAssert(boolBlock, @"未设置参数");
    forEachSelfCount
    {
        if (!boolBlock(self[i])) {
            return NO;
        }
    }
    return YES;
}

- (BOOL)any
{
    return self.count > 0;
}

- (BOOL)any:(BoolBlock)boolBlock
{
    NSAssert(boolBlock, @"未设置参数");
    forEachSelfCount
    {
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
    NSAssert(obj, @"有找到任何满足条件的对象");
    return obj;
}

- (id)firstOrNull:(BoolBlock)boolBlock
{
    NSAssert(boolBlock, @"未设置参数");
    forEachSelfCount
    {
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
    forEachSelfCount
    {
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

- (NSArray*)convertToOtherObjectWithBlock:(IDBlock)block
{
    NSAssert(block, @"未设置参数");
    NSMutableArray* resultArrayM = [NSMutableArray arrayWithCapacity:self.count];
    forEachSelfCount
    {
        id item = self[i];
        id resultObj = block(item);
        [resultArrayM addObject:resultObj];
    }
    return resultArrayM;
}

- (NSArray*)joinWithArray:(NSArray*)array
{
    NSMutableArray* resultArrayM = [NSMutableArray arrayWithCapacity:self.count + array.count];
    [resultArrayM addObjectsFromArray:self];
    [resultArrayM addObjectsFromArray:array];
    return resultArrayM.copy;
}

- (id)last
{
    return [self lastObject];
}
- (id)lastWithBlock:(BoolBlock)block
{
    NSAssert(block, @"未设置参数");
    NSMutableArray* resultArray = [NSMutableArray array];
    forEachSelfCount
    {
        id item = self[i];
        if (block(item)) {
            [resultArray addObject:item];
        }
    }
    return [resultArray last];
}
- (float)sumWithBlock:(FloatBlock)block
{
    NSAssert(block, @"未设置参数");
    float sum = 0;
    forEachSelfCount
    {
        id item = self[i];
        sum += block(item);
    }
    return sum;
}
- (NSInteger)longCountWithBlock:(BoolBlock)block
{
    return [[self where:block] count];
}

- (float)maxWithBlock:(FloatBlock)block
{
    NSAssert(block, @"未设置参数");
    float max = 0;
    forEachSelfCount
    {
        id item = self[i];
        float currentFloat = block(item);
        if (currentFloat > max) {
            max = currentFloat;
        }
    }
    return max;
}
- (float)minWithBlock:(FloatBlock)block
{
    NSAssert(block, @"未设置参数");
    float min = 0;
    forEachSelfCount
    {
        id item = self[i];
        float currentFloat = block(item);
        if (i == 0) {
            min = currentFloat;
        }
        if (currentFloat < min) {
            min = currentFloat;
        }
    }
    return min;
}
- (NSArray*)selectWithBlock:(IDBlock)block
{
    NSAssert(block, @"未设置参数");
     NSMutableArray* resultArrayM = [NSMutableArray arrayWithCapacity:self.count];
    forEachSelfCount
    {
        id item = self[i];
        id resultObj = block(item);
        [resultArrayM addObject:resultObj];
    }
    return resultArrayM.copy;
}

@end
