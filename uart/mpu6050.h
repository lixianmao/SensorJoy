/*
 * mpu6050.h
 *
 *  Created on: 2015-6-25
 *      Author: Administrator
 */
#include <msp430.h>
#ifndef MPU6050_H_
#define MPU6050_H_

//****************************************
// ����MPU6050�ڲ���ַ
//****************************************
#define	SMPLRT_DIV		0x19	//�����ǲ����ʣ�����ֵ��0x07(125Hz)
#define	CONFIG			0x1A	//��ͨ�˲�Ƶ�ʣ�����ֵ��0x06(5Hz)
#define	GYRO_CONFIG		0x1B	//�������Լ켰������Χ������ֵ��0x18(���Լ죬2000deg/s)
#define	ACCEL_CONFIG	0x1C	//���ټ��Լ졢������Χ����ͨ�˲�Ƶ�ʣ�����ֵ��0x01(���Լ죬2G��5Hz)
#define	ACCEL_XOUT_H	0x3B    //���ٶ�
#define	ACCEL_XOUT_L	0x3C
#define	ACCEL_YOUT_H	0x3D
#define	ACCEL_YOUT_L	0x3E
#define	ACCEL_ZOUT_H	0x3F
#define	ACCEL_ZOUT_L	0x40
#define	TEMP_OUT_H		0x41
#define	TEMP_OUT_L		0x42
#define	GYRO_XOUT_H		0x43    //���ٶ�
#define	GYRO_XOUT_L		0x44
#define	GYRO_YOUT_H		0x45
#define	GYRO_YOUT_L		0x46
#define	GYRO_ZOUT_H		0x47
#define	GYRO_ZOUT_L		0x48
#define	PWR_MGMT_1		0x6B	//��Դ��������ֵ��0x00(��������)
#define SlaveAddress	0xD0    //MPU6050 address when AD0==0.
#define uint unsigned int
#define uchar unsigned char
//****************************************
// ����SCL��SDA�ź��ڲ���ַ
//****************************************
#define SDA_L 		P1OUT &= ~BIT7
#define SDA_H 		P1OUT |= BIT7
#define SDA_OUT 	P1DIR |= BIT7
#define SDA_IN		P1DIR &= ~BIT7
#define SDA_DATA	P1IN & BIT7
#define SCL_L		P1OUT &= ~BIT6
#define SCL_H		P1OUT |= BIT6
#define SCL_OUT		P1DIR |= BIT6

void MPU6050_Init();
void GPIO_init();
// X/Y/Z-Axis Acceleration
int GetAccelX ();
int GetAccelY ();
int GetAccelZ ();

// X/Y/Z-Axis Angular velocity
int GetAnguX ();
int GetAnguY ();
int GetAnguZ ();


#endif /* MPU6050_H_ */
