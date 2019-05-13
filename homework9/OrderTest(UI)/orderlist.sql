/*
 Navicat Premium Data Transfer

 Source Server         : 本地
 Source Server Type    : MySQL
 Source Server Version : 80016
 Source Host           : localhost:3306
 Source Schema         : orderlists

 Target Server Type    : MySQL
 Target Server Version : 80016
 File Encoding         : 65001

 Date: 08/05/2019 21:38:54
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for orderlist
-- ----------------------------
DROP TABLE IF EXISTS `orderlist`;
CREATE TABLE `orderlist`  (
  `OrderId` int(11) NOT NULL AUTO_INCREMENT,
  `Product` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Client` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Buy_count` int(255) NULL DEFAULT NULL,
  `Price` double(10, 2) NULL DEFAULT NULL,
  PRIMARY KEY (`OrderId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of orderlist
-- ----------------------------
INSERT INTO `orderlist` VALUES (1, 'Apple', 'Frank', 2, 5999.00);
INSERT INTO `orderlist` VALUES (2, 'HUAWEI', 'Jasmine', 1, 3899.00);
INSERT INTO `orderlist` VALUES (3, 'SamSung', 'Excelsior', 2, 2699.00);
INSERT INTO `orderlist` VALUES (4, 'Samsung', 'Frankie', 2, 5699.00);
INSERT INTO `orderlist` VALUES (5, 'OPPO', 'Sam', 3, 3899.00);

SET FOREIGN_KEY_CHECKS = 1;
