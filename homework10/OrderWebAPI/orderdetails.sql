/*
 Navicat Premium Data Transfer

 Source Server         : 本地
 Source Server Type    : MySQL
 Source Server Version : 80016
 Source Host           : localhost:3306
 Source Schema         : ordermenu

 Target Server Type    : MySQL
 Target Server Version : 80016
 File Encoding         : 65001

 Date: 14/05/2019 07:31:46
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for orderdetails
-- ----------------------------
DROP TABLE IF EXISTS `orderdetails`;
CREATE TABLE `orderdetails`  (
  `Id` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `GoodsName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `Price` double NOT NULL,
  `Count` int(11) NOT NULL,
  `OrderId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE,
  INDEX `IX_OrderDetails_OrderId`(`OrderId`) USING BTREE,
  CONSTRAINT `FK_OrderDetails_Orders_OrderId` FOREIGN KEY (`OrderId`) REFERENCES `orders` (`Id`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of orderdetails
-- ----------------------------
INSERT INTO `orderdetails` VALUES ('1', 'Apple', 5999, 1, '1');
INSERT INTO `orderdetails` VALUES ('2', 'HUAWEI', 3899, 2, '2');
INSERT INTO `orderdetails` VALUES ('3', 'Samsung', 2699, 2, '3');
INSERT INTO `orderdetails` VALUES ('4', 'Samsung', 5699, 1, '4');
INSERT INTO `orderdetails` VALUES ('5', 'OPPO', 3899, 3, '5');

-- ----------------------------
-- Table structure for orders
-- ----------------------------
DROP TABLE IF EXISTS `orders`;
CREATE TABLE `orders`  (
  `Id` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Client` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `Price` double NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of orders
-- ----------------------------
INSERT INTO `orders` VALUES ('1', 'Frank', 5999);
INSERT INTO `orders` VALUES ('2', 'Jasmine', 3899);
INSERT INTO `orders` VALUES ('3', 'Samsung', 2699);
INSERT INTO `orders` VALUES ('4', 'Frankie', 5699);
INSERT INTO `orders` VALUES ('5', 'OPPO', 3899);

SET FOREIGN_KEY_CHECKS = 1;
