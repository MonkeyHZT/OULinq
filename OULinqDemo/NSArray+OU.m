//
//  NSArray+OU.m
//  OULinqDemo
//
//  Created by HouZhiTong on 15/11/16.
//  Copyright © 2015年 com.houzhitong. All rights reserved.
//

#import "NSArray+OU.h"

@implementation NSArray (OU)

- (BOOL)All:(BoolBlock)boolBlock
{
    for (int i = 0; i < [self count]; i++) {
        if (!boolBlock(self[i])) {
            return NO;
        }
    }
    return YES;
}

- (BOOL)Any
{
    return [self count] > 0;
} 

- (BOOL)Any:(BoolBlock)boolBlock
{
    for (int i = 0; i < [self count]; i++) {
        if (boolBlock(self[i])) {
            return YES;
        }
    }
    return NO;
}
@end
