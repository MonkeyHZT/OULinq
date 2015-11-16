//
//  ViewController.m
//  OULinqDemo
//
//  Created by HouZhiTong on 15/11/16.
//  Copyright © 2015年 com.houzhitong. All rights reserved.
//

#import "ViewController.h"
#import "OULinq.h"

@interface ViewController ()
@end
@implementation ViewController
//- (void)viewDidLoad {
//    [super viewDidLoad];
//    // Do any additional setup after loading the view, typically from a nib.
//}

-(void)touchesBegan:(NSSet<UITouch *> *)touches withEvent:(UIEvent *)event
{
    NSArray *array = @[@"a",@"b",@"c"];
    NSLog(@"%d",[array Any:^BOOL(NSString * parameter) {
        return [parameter isEqual: @"a"];
    }]);
}

@end
