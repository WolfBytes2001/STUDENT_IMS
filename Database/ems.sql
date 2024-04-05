/*
 Navicat Premium Data Transfer

 Source Server         : mysql
 Source Server Type    : MySQL
 Source Server Version : 100428 (10.4.28-MariaDB)
 Source Host           : localhost:3306
 Source Schema         : ems

 Target Server Type    : MySQL
 Target Server Version : 100428 (10.4.28-MariaDB)
 File Encoding         : 65001

 Date: 26/02/2024 13:41:15
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for department
-- ----------------------------
DROP TABLE IF EXISTS `department`;
CREATE TABLE `department`  (
  `Seq_IDnum` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Department` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_bin ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of department
-- ----------------------------
INSERT INTO `department` VALUES ('1', 'CAS');
INSERT INTO `department` VALUES ('2', 'CBA');
INSERT INTO `department` VALUES ('3', 'MTE');
INSERT INTO `department` VALUES ('4', 'CNAHS');
INSERT INTO `department` VALUES ('5', 'COE');
INSERT INTO `department` VALUES ('6', 'CME');
INSERT INTO `department` VALUES ('7', 'GRADUATE STUDIES');
INSERT INTO `department` VALUES ('8', 'CJD');
INSERT INTO `department` VALUES ('9', 'CCJE');
INSERT INTO `department` VALUES ('10', 'ADMINISTRATION');
INSERT INTO `department` VALUES ('11', 'RESEARCH');
INSERT INTO `department` VALUES ('12', 'EXTENSION');
INSERT INTO `department` VALUES ('13', 'SECURITY');
INSERT INTO `department` VALUES ('14', 'GSO');
INSERT INTO `department` VALUES ('15', 'UDRRMO');
INSERT INTO `department` VALUES ('16', 'MISO');
INSERT INTO `department` VALUES ('17', 'QAC');
INSERT INTO `department` VALUES ('18', 'IMD');
INSERT INTO `department` VALUES ('19', 'COMPUTER LABORATORY');
INSERT INTO `department` VALUES ('20', 'FAB LABORATORY');
INSERT INTO `department` VALUES ('21', 'NATSCI LABORATORY');
INSERT INTO `department` VALUES ('22', 'GENSCI LABORATORY');
INSERT INTO `department` VALUES ('23', 'CME LABORATORY');
INSERT INTO `department` VALUES ('24', 'UNIVERSITY LIBRARY');
INSERT INTO `department` VALUES ('25', 'CNAHS LABORATORY');
INSERT INTO `department` VALUES ('26', 'JUNIOR HIGH SCHOOL');
INSERT INTO `department` VALUES ('27', 'GUIDANCE');
INSERT INTO `department` VALUES ('28', 'FLS');
INSERT INTO `department` VALUES ('29', 'i18N');
INSERT INTO `department` VALUES ('30', 'RECORD OFFICE');
INSERT INTO `department` VALUES ('31', 'DSAS');
INSERT INTO `department` VALUES ('32', 'KTTO');
INSERT INTO `department` VALUES ('33', 'LMS');
INSERT INTO `department` VALUES ('34', 'PESA');
INSERT INTO `department` VALUES ('35', 'GAD');
INSERT INTO `department` VALUES ('36', 'TESDA');
INSERT INTO `department` VALUES ('37', 'CAO');
INSERT INTO `department` VALUES ('38', 'CCS');
INSERT INTO `department` VALUES ('39', 'CBA-SSG-SMM');
INSERT INTO `department` VALUES ('40', 'LUNDAYAN');
INSERT INTO `department` VALUES ('41', 'University Registrar');
INSERT INTO `department` VALUES ('42', 'OFFICE OF THE PRESIDENT');
INSERT INTO `department` VALUES ('43', 'CULTURAL AND SPORTS');
INSERT INTO `department` VALUES ('44', 'PUBLICATION');
INSERT INTO `department` VALUES ('45', 'CWMC');
INSERT INTO `department` VALUES ('46', 'NSTP');
INSERT INTO `department` VALUES ('47', 'FMO');
INSERT INTO `department` VALUES ('48', 'SYSTEM BUDGET OFFICE');
INSERT INTO `department` VALUES ('48', 'BUDGET OFFICE');
INSERT INTO `department` VALUES ('49', 'COA');
INSERT INTO `department` VALUES ('50', 'OFFICE MAIN SSG');
INSERT INTO `department` VALUES ('51', 'Board Secretary');
INSERT INTO `department` VALUES ('52', 'Cashier Office');
INSERT INTO `department` VALUES ('53', 'Accounting Office');
INSERT INTO `department` VALUES ('54', 'PLANNING OFFICE');
INSERT INTO `department` VALUES ('55', 'BAC');
INSERT INTO `department` VALUES ('56', 'CCS-SSG-CS');
INSERT INTO `department` VALUES ('57', 'MTE');
INSERT INTO `department` VALUES ('58', 'DRIVER');
INSERT INTO `department` VALUES ('59', 'LAN/WAN Administrator');
INSERT INTO `department` VALUES ('60', 'HRMO');
INSERT INTO `department` VALUES ('61', 'SUPPLY OFFICE\r\n');
INSERT INTO `department` VALUES ('62', 'VPAD');
INSERT INTO `department` VALUES ('63', 'VPAA');
INSERT INTO `department` VALUES ('64', 'CBA-SSG-MTHM');
INSERT INTO `department` VALUES ('65', 'SSG-MAIN');
INSERT INTO `department` VALUES ('66', 'CBA-SSG');
INSERT INTO `department` VALUES ('67', 'CNAHS-SSG');
INSERT INTO `department` VALUES ('68', 'CBA-SSG-JCF');
INSERT INTO `department` VALUES ('69', 'CBA-JPIA');
INSERT INTO `department` VALUES ('70', 'CBA-SSG-ENTREP');
INSERT INTO `department` VALUES ('71', 'CBA-SSG');
INSERT INTO `department` VALUES ('72', 'CAS-POL.SCI');
INSERT INTO `department` VALUES ('73', 'GUIDANCE-T');
INSERT INTO `department` VALUES ('74', 'COE-IIEEP');
INSERT INTO `department` VALUES ('75', 'CED-SSG');
INSERT INTO `department` VALUES ('76', 'MBO');
INSERT INTO `department` VALUES ('77', 'CBA-SSG-HMS');
INSERT INTO `department` VALUES ('78', 'STATE COLLEGIAN');
INSERT INTO `department` VALUES ('79', 'CED-SSG-ENGLISH');
INSERT INTO `department` VALUES ('80', 'CED-HUMAN-KENETIC');
INSERT INTO `department` VALUES ('81', 'CED-SSG-GEN-SOC');
INSERT INTO `department` VALUES ('82', 'CED-SSG-MATH');
INSERT INTO `department` VALUES ('83', 'CNAHS-LSN');
INSERT INTO `department` VALUES ('84', 'RLE-HRM');
INSERT INTO `department` VALUES ('85', 'UNIVERSITY CLINIC');
INSERT INTO `department` VALUES ('86', 'CAS-SSG');
INSERT INTO `department` VALUES ('87', 'POEM');
INSERT INTO `department` VALUES ('88', 'CBA-SSG-TM');
INSERT INTO `department` VALUES ('89', 'CASHIER');
INSERT INTO `department` VALUES ('90', 'CAD');
INSERT INTO `department` VALUES ('91', 'CED');
INSERT INTO `department` VALUES ('92', 'CED-SSG-SAMAFIL');
INSERT INTO `department` VALUES ('93', 'CED-SSG-GES');
INSERT INTO `department` VALUES ('94', 'FSO');
INSERT INTO `department` VALUES ('95', 'TIYATRO DANSULAN');
INSERT INTO `department` VALUES ('96', 'COA');
INSERT INTO `department` VALUES ('97', 'Phil. Ins. Of Civil Engineers (PICE)');
INSERT INTO `department` VALUES ('98', 'COE-SSG');
INSERT INTO `department` VALUES ('99', 'COE-ACES');
INSERT INTO `department` VALUES ('100', 'VPRDE');
INSERT INTO `department` VALUES ('101', 'CED-ENG. CIRCLE\r\n');
INSERT INTO `department` VALUES ('102', 'CCS-SSG\r\n');
INSERT INTO `department` VALUES ('103', 'LUNDAYAN DANCE TROUPE\r\n');
INSERT INTO `department` VALUES ('104', 'CCS-SSG-IS');
INSERT INTO `department` VALUES ('105', 'CNAHS-ASM\r\n');
INSERT INTO `department` VALUES ('106', 'IES');
INSERT INTO `department` VALUES ('107', 'StuFaPs');
INSERT INTO `department` VALUES ('108', 'CAS-MARINE-BIO');
INSERT INTO `department` VALUES ('109', 'COE-ICOMPE\r\n');

-- ----------------------------
-- Table structure for designation
-- ----------------------------
DROP TABLE IF EXISTS `designation`;
CREATE TABLE `designation`  (
  `Seq_IDnum` int NULL DEFAULT NULL,
  `Designation` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_bin ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of designation
-- ----------------------------
INSERT INTO `designation` VALUES (1, 'University President');
INSERT INTO `designation` VALUES (2, 'VP for Academic Affairs');
INSERT INTO `designation` VALUES (3, 'VP for Administration');
INSERT INTO `designation` VALUES (4, 'VP for Research, Extension and Development');
INSERT INTO `designation` VALUES (5, 'Campus Administrator');
INSERT INTO `designation` VALUES (6, 'Chief Administrative Officer');
INSERT INTO `designation` VALUES (7, 'Dean');
INSERT INTO `designation` VALUES (8, 'Program Head');
INSERT INTO `designation` VALUES (9, 'Program Chairperson');
INSERT INTO `designation` VALUES (10, 'Unit Head');
INSERT INTO `designation` VALUES (11, 'Associate Dean');
INSERT INTO `designation` VALUES (12, 'Accountant');
INSERT INTO `designation` VALUES (13, 'Cashier');
INSERT INTO `designation` VALUES (14, 'Director');
INSERT INTO `designation` VALUES (15, 'Program Coordinator');
INSERT INTO `designation` VALUES (16, 'Stokeeper');
INSERT INTO `designation` VALUES (17, 'Supply Officer');
INSERT INTO `designation` VALUES (18, 'Board Secretary');
INSERT INTO `designation` VALUES (19, 'Executive Asistant Secretary');
INSERT INTO `designation` VALUES (20, 'University Registrar');
INSERT INTO `designation` VALUES (21, 'GSO Officer');
INSERT INTO `designation` VALUES (22, 'BAC Secretariat');
INSERT INTO `designation` VALUES (23, 'MISO');
INSERT INTO `designation` VALUES (24, 'PRINCIPAL');
INSERT INTO `designation` VALUES (25, 'GUIDANCE COUNSELOR');
INSERT INTO `designation` VALUES (26, 'UNIVERSITY NURSE');
INSERT INTO `designation` VALUES (27, 'Records Officer');
INSERT INTO `designation` VALUES (28, 'Librarian');
INSERT INTO `designation` VALUES (29, 'Cultural and Sports Coordinator');
INSERT INTO `designation` VALUES (30, 'NSTP');
INSERT INTO `designation` VALUES (31, 'STO');
INSERT INTO `designation` VALUES (32, 'OJT Coordinator');
INSERT INTO `designation` VALUES (33, 'Office Secretary');
INSERT INTO `designation` VALUES (34, 'Focal Person');
INSERT INTO `designation` VALUES (35, 'FMO');
INSERT INTO `designation` VALUES (36, 'Budget ');
INSERT INTO `designation` VALUES (37, 'Symtem Budget Officer');
INSERT INTO `designation` VALUES (38, 'State Auditor III');
INSERT INTO `designation` VALUES (39, 'faculty');
INSERT INTO `designation` VALUES (40, 'MTE');
INSERT INTO `designation` VALUES (41, 'DRIVER');
INSERT INTO `designation` VALUES (42, 'JANITOR');
INSERT INTO `designation` VALUES (43, 'Administrative Aide');
INSERT INTO `designation` VALUES (44, 'Planning Officer');
INSERT INTO `designation` VALUES (45, 'HRMO');

-- ----------------------------
-- Table structure for employees
-- ----------------------------
DROP TABLE IF EXISTS `employees`;
CREATE TABLE `employees`  (
  `id` int NOT NULL AUTO_INCREMENT,
  `employee_id` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `fullname` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `username` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `password` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `email` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `designation` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `added_at` datetime NOT NULL DEFAULT current_timestamp,
  `department` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `status` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `remarks` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 27 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of employees
-- ----------------------------
INSERT INTO `employees` VALUES (16, '20010', 'Renz L. Santiago', 'renz123', 'renz123', 'renz12@jrmsu', 'University President', '2024-02-24 13:07:03', 'CAS', 'Permanent', 'Active');
INSERT INTO `employees` VALUES (25, '21-A-00482', 'John Wick', 'wick123', 'wick123', 'wick@yahoo', 'Associate Dean', '2024-02-26 12:35:41', 'CAS', 'Permanent', 'Active');
INSERT INTO `employees` VALUES (26, '', '', 'admin', 'admin', '', NULL, '2024-02-26 13:07:36', NULL, NULL, NULL);

-- ----------------------------
-- Table structure for employment_remarks
-- ----------------------------
DROP TABLE IF EXISTS `employment_remarks`;
CREATE TABLE `employment_remarks`  (
  `status_id` int NOT NULL,
  `remarks` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`status_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of employment_remarks
-- ----------------------------
INSERT INTO `employment_remarks` VALUES (1, 'Active');
INSERT INTO `employment_remarks` VALUES (2, 'Resigned');
INSERT INTO `employment_remarks` VALUES (3, 'Vocation Leave');
INSERT INTO `employment_remarks` VALUES (4, 'Terminated');

-- ----------------------------
-- Table structure for employment_status
-- ----------------------------
DROP TABLE IF EXISTS `employment_status`;
CREATE TABLE `employment_status`  (
  `status_id` int NOT NULL,
  `remarks` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`status_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of employment_status
-- ----------------------------
INSERT INTO `employment_status` VALUES (1, 'Permanent');
INSERT INTO `employment_status` VALUES (2, 'Temporary');
INSERT INTO `employment_status` VALUES (3, 'Visiting Lecturer');
INSERT INTO `employment_status` VALUES (4, 'Contract of Service');

-- ----------------------------
-- Table structure for grades
-- ----------------------------
DROP TABLE IF EXISTS `grades`;
CREATE TABLE `grades`  (
  `student_id` int NOT NULL AUTO_INCREMENT,
  `subject1` double NOT NULL,
  `subject2` double NOT NULL,
  `subject3` double NOT NULL,
  PRIMARY KEY (`student_id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1001 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of grades
-- ----------------------------
INSERT INTO `grades` VALUES (1, 90, 90, 89);
INSERT INTO `grades` VALUES (2, 0, 0, 0);
INSERT INTO `grades` VALUES (3, 57, 49, 9);
INSERT INTO `grades` VALUES (4, 32, 65, 41);
INSERT INTO `grades` VALUES (5, 78, 69, 68);
INSERT INTO `grades` VALUES (6, 86, 31, 8);
INSERT INTO `grades` VALUES (7, 40, 81, 32);
INSERT INTO `grades` VALUES (8, 99, 97, 51);
INSERT INTO `grades` VALUES (9, 54, 69, 6);
INSERT INTO `grades` VALUES (10, 81, 75, 14);
INSERT INTO `grades` VALUES (11, 69, 14, 24);
INSERT INTO `grades` VALUES (12, 12, 98, 8);
INSERT INTO `grades` VALUES (13, 52, 8, 14);
INSERT INTO `grades` VALUES (14, 61, 12, 48);
INSERT INTO `grades` VALUES (15, 10, 43, 100);
INSERT INTO `grades` VALUES (16, 21, 52, 82);
INSERT INTO `grades` VALUES (17, 48, 51, 51);
INSERT INTO `grades` VALUES (18, 32, 62, 14);
INSERT INTO `grades` VALUES (19, 7, 61, 56);
INSERT INTO `grades` VALUES (20, 21, 27, 74);
INSERT INTO `grades` VALUES (21, 18, 9, 13);
INSERT INTO `grades` VALUES (22, 56, 97, 75);
INSERT INTO `grades` VALUES (23, 2, 56, 60);
INSERT INTO `grades` VALUES (24, 2, 28, 30);
INSERT INTO `grades` VALUES (25, 88, 46, 54);
INSERT INTO `grades` VALUES (26, 39, 57, 93);
INSERT INTO `grades` VALUES (27, 73, 66, 55);
INSERT INTO `grades` VALUES (28, 0, 65, 47);
INSERT INTO `grades` VALUES (29, 94, 67, 98);
INSERT INTO `grades` VALUES (30, 6, 34, 2);
INSERT INTO `grades` VALUES (31, 26, 75, 37);
INSERT INTO `grades` VALUES (32, 24, 48, 42);
INSERT INTO `grades` VALUES (33, 70, 14, 2);
INSERT INTO `grades` VALUES (34, 79, 48, 10);
INSERT INTO `grades` VALUES (35, 21, 3, 7);
INSERT INTO `grades` VALUES (36, 99, 24, 73);
INSERT INTO `grades` VALUES (37, 77, 96, 71);
INSERT INTO `grades` VALUES (38, 35, 53, 31);
INSERT INTO `grades` VALUES (39, 69, 94, 71);
INSERT INTO `grades` VALUES (40, 40, 67, 76);
INSERT INTO `grades` VALUES (41, 39, 30, 78);
INSERT INTO `grades` VALUES (42, 98, 86, 7);
INSERT INTO `grades` VALUES (43, 73, 56, 57);
INSERT INTO `grades` VALUES (44, 26, 36, 48);
INSERT INTO `grades` VALUES (45, 73, 94, 57);
INSERT INTO `grades` VALUES (46, 60, 6, 61);
INSERT INTO `grades` VALUES (47, 89, 37, 51);
INSERT INTO `grades` VALUES (48, 100, 50, 97);
INSERT INTO `grades` VALUES (49, 64, 90, 76);
INSERT INTO `grades` VALUES (50, 47, 95, 34);
INSERT INTO `grades` VALUES (51, 77, 64, 2);
INSERT INTO `grades` VALUES (52, 73, 26, 96);
INSERT INTO `grades` VALUES (53, 95, 94, 0);
INSERT INTO `grades` VALUES (54, 55, 7, 97);
INSERT INTO `grades` VALUES (55, 6, 90, 84);
INSERT INTO `grades` VALUES (56, 20, 6, 92);
INSERT INTO `grades` VALUES (57, 63, 40, 80);
INSERT INTO `grades` VALUES (58, 49, 87, 46);
INSERT INTO `grades` VALUES (59, 38, 40, 72);
INSERT INTO `grades` VALUES (60, 59, 37, 5);
INSERT INTO `grades` VALUES (61, 100, 20, 99);
INSERT INTO `grades` VALUES (62, 80, 18, 22);
INSERT INTO `grades` VALUES (63, 37, 62, 79);
INSERT INTO `grades` VALUES (64, 9, 25, 75);
INSERT INTO `grades` VALUES (65, 7, 58, 29);
INSERT INTO `grades` VALUES (66, 11, 67, 32);
INSERT INTO `grades` VALUES (67, 44, 33, 17);
INSERT INTO `grades` VALUES (68, 68, 7, 79);
INSERT INTO `grades` VALUES (69, 48, 61, 65);
INSERT INTO `grades` VALUES (70, 1, 18, 36);
INSERT INTO `grades` VALUES (71, 48, 75, 21);
INSERT INTO `grades` VALUES (72, 52, 77, 52);
INSERT INTO `grades` VALUES (73, 39, 9, 53);
INSERT INTO `grades` VALUES (74, 51, 60, 68);
INSERT INTO `grades` VALUES (75, 25, 12, 92);
INSERT INTO `grades` VALUES (76, 18, 20, 20);
INSERT INTO `grades` VALUES (77, 87, 62, 27);
INSERT INTO `grades` VALUES (78, 14, 73, 87);
INSERT INTO `grades` VALUES (79, 12, 77, 54);
INSERT INTO `grades` VALUES (80, 5, 72, 42);
INSERT INTO `grades` VALUES (81, 2, 71, 2);
INSERT INTO `grades` VALUES (82, 50, 91, 65);
INSERT INTO `grades` VALUES (83, 60, 15, 76);
INSERT INTO `grades` VALUES (84, 30, 9, 38);
INSERT INTO `grades` VALUES (85, 14, 16, 55);
INSERT INTO `grades` VALUES (86, 3, 50, 48);
INSERT INTO `grades` VALUES (87, 2, 26, 34);
INSERT INTO `grades` VALUES (88, 100, 66, 27);
INSERT INTO `grades` VALUES (89, 1, 7, 53);
INSERT INTO `grades` VALUES (90, 86, 67, 54);
INSERT INTO `grades` VALUES (91, 51, 79, 26);
INSERT INTO `grades` VALUES (92, 34, 3, 42);
INSERT INTO `grades` VALUES (93, 59, 2, 88);
INSERT INTO `grades` VALUES (94, 45, 9, 85);
INSERT INTO `grades` VALUES (95, 16, 13, 61);
INSERT INTO `grades` VALUES (96, 25, 61, 78);
INSERT INTO `grades` VALUES (97, 90, 89, 81);
INSERT INTO `grades` VALUES (98, 43, 60, 81);
INSERT INTO `grades` VALUES (99, 24, 76, 86);
INSERT INTO `grades` VALUES (100, 56, 99, 2);
INSERT INTO `grades` VALUES (101, 8, 73, 13);
INSERT INTO `grades` VALUES (102, 51, 47, 64);
INSERT INTO `grades` VALUES (103, 40, 34, 77);
INSERT INTO `grades` VALUES (104, 65, 33, 38);
INSERT INTO `grades` VALUES (105, 8, 2, 91);
INSERT INTO `grades` VALUES (106, 53, 89, 75);
INSERT INTO `grades` VALUES (107, 16, 68, 20);
INSERT INTO `grades` VALUES (108, 96, 79, 79);
INSERT INTO `grades` VALUES (109, 39, 43, 78);
INSERT INTO `grades` VALUES (110, 83, 49, 29);
INSERT INTO `grades` VALUES (111, 17, 39, 67);
INSERT INTO `grades` VALUES (112, 6, 16, 25);
INSERT INTO `grades` VALUES (113, 50, 28, 19);
INSERT INTO `grades` VALUES (114, 9, 66, 87);
INSERT INTO `grades` VALUES (115, 59, 36, 20);
INSERT INTO `grades` VALUES (116, 77, 86, 88);
INSERT INTO `grades` VALUES (117, 46, 47, 82);
INSERT INTO `grades` VALUES (118, 25, 83, 5);
INSERT INTO `grades` VALUES (119, 51, 18, 59);
INSERT INTO `grades` VALUES (120, 24, 77, 16);
INSERT INTO `grades` VALUES (121, 58, 15, 57);
INSERT INTO `grades` VALUES (122, 72, 59, 69);
INSERT INTO `grades` VALUES (123, 30, 40, 54);
INSERT INTO `grades` VALUES (124, 7, 18, 5);
INSERT INTO `grades` VALUES (125, 66, 76, 73);
INSERT INTO `grades` VALUES (126, 87, 27, 58);
INSERT INTO `grades` VALUES (127, 95, 57, 30);
INSERT INTO `grades` VALUES (128, 64, 1, 40);
INSERT INTO `grades` VALUES (129, 61, 76, 5);
INSERT INTO `grades` VALUES (130, 55, 25, 81);
INSERT INTO `grades` VALUES (131, 3, 52, 74);
INSERT INTO `grades` VALUES (132, 56, 83, 29);
INSERT INTO `grades` VALUES (133, 75, 78, 68);
INSERT INTO `grades` VALUES (134, 78, 10, 30);
INSERT INTO `grades` VALUES (135, 56, 5, 43);
INSERT INTO `grades` VALUES (136, 88, 14, 20);
INSERT INTO `grades` VALUES (137, 26, 68, 30);
INSERT INTO `grades` VALUES (138, 36, 93, 34);
INSERT INTO `grades` VALUES (139, 8, 100, 8);
INSERT INTO `grades` VALUES (140, 11, 3, 6);
INSERT INTO `grades` VALUES (141, 13, 86, 18);
INSERT INTO `grades` VALUES (142, 30, 91, 69);
INSERT INTO `grades` VALUES (143, 64, 13, 64);
INSERT INTO `grades` VALUES (144, 91, 6, 56);
INSERT INTO `grades` VALUES (145, 54, 2, 100);
INSERT INTO `grades` VALUES (146, 22, 6, 55);
INSERT INTO `grades` VALUES (147, 68, 20, 66);
INSERT INTO `grades` VALUES (148, 44, 56, 52);
INSERT INTO `grades` VALUES (149, 36, 70, 58);
INSERT INTO `grades` VALUES (150, 68, 56, 64);
INSERT INTO `grades` VALUES (151, 73, 84, 52);
INSERT INTO `grades` VALUES (152, 90, 32, 90);
INSERT INTO `grades` VALUES (153, 83, 46, 76);
INSERT INTO `grades` VALUES (154, 41, 22, 99);
INSERT INTO `grades` VALUES (155, 83, 15, 62);
INSERT INTO `grades` VALUES (156, 32, 12, 8);
INSERT INTO `grades` VALUES (157, 23, 51, 10);
INSERT INTO `grades` VALUES (158, 42, 41, 36);
INSERT INTO `grades` VALUES (159, 81, 31, 88);
INSERT INTO `grades` VALUES (160, 5, 32, 78);
INSERT INTO `grades` VALUES (161, 5, 31, 74);
INSERT INTO `grades` VALUES (162, 12, 77, 21);
INSERT INTO `grades` VALUES (163, 47, 55, 68);
INSERT INTO `grades` VALUES (164, 53, 15, 7);
INSERT INTO `grades` VALUES (165, 74, 53, 28);
INSERT INTO `grades` VALUES (166, 97, 20, 30);
INSERT INTO `grades` VALUES (167, 25, 42, 71);
INSERT INTO `grades` VALUES (168, 23, 31, 22);
INSERT INTO `grades` VALUES (169, 14, 31, 43);
INSERT INTO `grades` VALUES (170, 98, 84, 3);
INSERT INTO `grades` VALUES (171, 30, 62, 34);
INSERT INTO `grades` VALUES (172, 23, 41, 44);
INSERT INTO `grades` VALUES (173, 30, 21, 91);
INSERT INTO `grades` VALUES (174, 92, 37, 61);
INSERT INTO `grades` VALUES (175, 88, 77, 52);
INSERT INTO `grades` VALUES (176, 84, 71, 86);
INSERT INTO `grades` VALUES (177, 45, 76, 63);
INSERT INTO `grades` VALUES (178, 98, 52, 10);
INSERT INTO `grades` VALUES (179, 7, 26, 18);
INSERT INTO `grades` VALUES (180, 45, 53, 40);
INSERT INTO `grades` VALUES (181, 68, 61, 22);
INSERT INTO `grades` VALUES (182, 23, 65, 98);
INSERT INTO `grades` VALUES (183, 33, 100, 74);
INSERT INTO `grades` VALUES (184, 71, 82, 38);
INSERT INTO `grades` VALUES (185, 79, 3, 58);
INSERT INTO `grades` VALUES (186, 99, 97, 39);
INSERT INTO `grades` VALUES (187, 76, 5, 91);
INSERT INTO `grades` VALUES (188, 70, 38, 28);
INSERT INTO `grades` VALUES (189, 60, 65, 53);
INSERT INTO `grades` VALUES (190, 29, 87, 74);
INSERT INTO `grades` VALUES (191, 94, 15, 34);
INSERT INTO `grades` VALUES (192, 78, 45, 8);
INSERT INTO `grades` VALUES (193, 4, 80, 12);
INSERT INTO `grades` VALUES (194, 60, 80, 46);
INSERT INTO `grades` VALUES (195, 60, 26, 77);
INSERT INTO `grades` VALUES (196, 50, 86, 73);
INSERT INTO `grades` VALUES (197, 4, 23, 34);
INSERT INTO `grades` VALUES (198, 1, 56, 94);
INSERT INTO `grades` VALUES (199, 3, 56, 14);
INSERT INTO `grades` VALUES (200, 60, 82, 76);
INSERT INTO `grades` VALUES (201, 44, 80, 49);
INSERT INTO `grades` VALUES (202, 84, 31, 100);
INSERT INTO `grades` VALUES (203, 90, 69, 41);
INSERT INTO `grades` VALUES (204, 1, 61, 27);
INSERT INTO `grades` VALUES (205, 64, 60, 70);
INSERT INTO `grades` VALUES (206, 18, 14, 71);
INSERT INTO `grades` VALUES (207, 76, 94, 60);
INSERT INTO `grades` VALUES (208, 53, 8, 86);
INSERT INTO `grades` VALUES (209, 4, 91, 34);
INSERT INTO `grades` VALUES (210, 65, 46, 42);
INSERT INTO `grades` VALUES (211, 37, 97, 36);
INSERT INTO `grades` VALUES (212, 1, 92, 5);
INSERT INTO `grades` VALUES (213, 24, 27, 56);
INSERT INTO `grades` VALUES (214, 36, 59, 78);
INSERT INTO `grades` VALUES (215, 8, 8, 33);
INSERT INTO `grades` VALUES (216, 96, 35, 34);
INSERT INTO `grades` VALUES (217, 51, 92, 63);
INSERT INTO `grades` VALUES (218, 79, 39, 50);
INSERT INTO `grades` VALUES (219, 89, 73, 39);
INSERT INTO `grades` VALUES (220, 97, 88, 50);
INSERT INTO `grades` VALUES (221, 26, 48, 55);
INSERT INTO `grades` VALUES (222, 83, 43, 56);
INSERT INTO `grades` VALUES (223, 20, 8, 87);
INSERT INTO `grades` VALUES (224, 81, 61, 67);
INSERT INTO `grades` VALUES (225, 57, 48, 62);
INSERT INTO `grades` VALUES (226, 81, 27, 22);
INSERT INTO `grades` VALUES (227, 73, 99, 83);
INSERT INTO `grades` VALUES (228, 53, 94, 48);
INSERT INTO `grades` VALUES (229, 85, 26, 66);
INSERT INTO `grades` VALUES (230, 63, 73, 43);
INSERT INTO `grades` VALUES (231, 19, 90, 15);
INSERT INTO `grades` VALUES (232, 57, 61, 23);
INSERT INTO `grades` VALUES (233, 58, 49, 24);
INSERT INTO `grades` VALUES (234, 72, 26, 58);
INSERT INTO `grades` VALUES (235, 97, 27, 71);
INSERT INTO `grades` VALUES (236, 45, 50, 37);
INSERT INTO `grades` VALUES (237, 7, 86, 72);
INSERT INTO `grades` VALUES (238, 3, 10, 65);
INSERT INTO `grades` VALUES (239, 75, 50, 60);
INSERT INTO `grades` VALUES (240, 84, 72, 37);
INSERT INTO `grades` VALUES (241, 51, 7, 42);
INSERT INTO `grades` VALUES (242, 31, 4, 81);
INSERT INTO `grades` VALUES (243, 50, 37, 91);
INSERT INTO `grades` VALUES (244, 69, 14, 21);
INSERT INTO `grades` VALUES (245, 8, 60, 70);
INSERT INTO `grades` VALUES (246, 87, 72, 63);
INSERT INTO `grades` VALUES (247, 94, 56, 31);
INSERT INTO `grades` VALUES (248, 52, 86, 45);
INSERT INTO `grades` VALUES (249, 87, 37, 28);
INSERT INTO `grades` VALUES (250, 68, 0, 80);
INSERT INTO `grades` VALUES (251, 17, 68, 10);
INSERT INTO `grades` VALUES (252, 47, 96, 51);
INSERT INTO `grades` VALUES (253, 17, 81, 99);
INSERT INTO `grades` VALUES (254, 88, 4, 91);
INSERT INTO `grades` VALUES (255, 82, 44, 20);
INSERT INTO `grades` VALUES (256, 54, 41, 94);
INSERT INTO `grades` VALUES (257, 20, 70, 18);
INSERT INTO `grades` VALUES (258, 80, 21, 69);
INSERT INTO `grades` VALUES (259, 13, 68, 27);
INSERT INTO `grades` VALUES (260, 89, 63, 49);
INSERT INTO `grades` VALUES (261, 31, 12, 2);
INSERT INTO `grades` VALUES (262, 46, 27, 54);
INSERT INTO `grades` VALUES (263, 98, 8, 93);
INSERT INTO `grades` VALUES (264, 75, 47, 47);
INSERT INTO `grades` VALUES (265, 79, 7, 42);
INSERT INTO `grades` VALUES (266, 77, 34, 62);
INSERT INTO `grades` VALUES (267, 5, 14, 91);
INSERT INTO `grades` VALUES (268, 68, 23, 83);
INSERT INTO `grades` VALUES (269, 98, 38, 85);
INSERT INTO `grades` VALUES (270, 31, 39, 35);
INSERT INTO `grades` VALUES (271, 53, 55, 44);
INSERT INTO `grades` VALUES (272, 2, 72, 32);
INSERT INTO `grades` VALUES (273, 84, 8, 90);
INSERT INTO `grades` VALUES (274, 34, 38, 16);
INSERT INTO `grades` VALUES (275, 21, 59, 16);
INSERT INTO `grades` VALUES (276, 15, 5, 8);
INSERT INTO `grades` VALUES (277, 30, 6, 39);
INSERT INTO `grades` VALUES (278, 14, 1, 27);
INSERT INTO `grades` VALUES (279, 52, 80, 3);
INSERT INTO `grades` VALUES (280, 41, 6, 30);
INSERT INTO `grades` VALUES (281, 73, 30, 53);
INSERT INTO `grades` VALUES (282, 31, 45, 13);
INSERT INTO `grades` VALUES (283, 23, 91, 32);
INSERT INTO `grades` VALUES (284, 91, 74, 36);
INSERT INTO `grades` VALUES (285, 1, 76, 54);
INSERT INTO `grades` VALUES (286, 25, 1, 45);
INSERT INTO `grades` VALUES (287, 15, 9, 30);
INSERT INTO `grades` VALUES (288, 32, 1, 1);
INSERT INTO `grades` VALUES (289, 94, 28, 51);
INSERT INTO `grades` VALUES (290, 18, 14, 48);
INSERT INTO `grades` VALUES (291, 88, 2, 41);
INSERT INTO `grades` VALUES (292, 87, 97, 25);
INSERT INTO `grades` VALUES (293, 4, 69, 73);
INSERT INTO `grades` VALUES (294, 74, 7, 28);
INSERT INTO `grades` VALUES (295, 58, 97, 21);
INSERT INTO `grades` VALUES (296, 97, 56, 14);
INSERT INTO `grades` VALUES (297, 23, 7, 13);
INSERT INTO `grades` VALUES (298, 87, 25, 27);
INSERT INTO `grades` VALUES (299, 62, 17, 77);
INSERT INTO `grades` VALUES (300, 24, 83, 35);
INSERT INTO `grades` VALUES (301, 18, 24, 19);
INSERT INTO `grades` VALUES (302, 30, 3, 60);
INSERT INTO `grades` VALUES (303, 23, 14, 11);
INSERT INTO `grades` VALUES (304, 42, 48, 33);
INSERT INTO `grades` VALUES (305, 99, 78, 5);
INSERT INTO `grades` VALUES (306, 81, 56, 92);
INSERT INTO `grades` VALUES (307, 25, 26, 60);
INSERT INTO `grades` VALUES (308, 20, 6, 21);
INSERT INTO `grades` VALUES (309, 34, 3, 74);
INSERT INTO `grades` VALUES (310, 40, 21, 17);
INSERT INTO `grades` VALUES (311, 14, 54, 58);
INSERT INTO `grades` VALUES (312, 28, 84, 15);
INSERT INTO `grades` VALUES (313, 12, 78, 30);
INSERT INTO `grades` VALUES (314, 91, 29, 28);
INSERT INTO `grades` VALUES (315, 14, 41, 47);
INSERT INTO `grades` VALUES (316, 27, 72, 41);
INSERT INTO `grades` VALUES (317, 70, 26, 35);
INSERT INTO `grades` VALUES (318, 73, 76, 3);
INSERT INTO `grades` VALUES (319, 39, 67, 43);
INSERT INTO `grades` VALUES (320, 10, 64, 44);
INSERT INTO `grades` VALUES (321, 95, 2, 39);
INSERT INTO `grades` VALUES (322, 97, 41, 94);
INSERT INTO `grades` VALUES (323, 96, 13, 100);
INSERT INTO `grades` VALUES (324, 35, 26, 65);
INSERT INTO `grades` VALUES (325, 33, 81, 60);
INSERT INTO `grades` VALUES (326, 66, 98, 76);
INSERT INTO `grades` VALUES (327, 38, 47, 86);
INSERT INTO `grades` VALUES (328, 58, 46, 27);
INSERT INTO `grades` VALUES (329, 86, 42, 85);
INSERT INTO `grades` VALUES (330, 85, 42, 95);
INSERT INTO `grades` VALUES (331, 33, 84, 73);
INSERT INTO `grades` VALUES (332, 89, 62, 82);
INSERT INTO `grades` VALUES (333, 5, 38, 56);
INSERT INTO `grades` VALUES (334, 43, 70, 41);
INSERT INTO `grades` VALUES (335, 12, 48, 32);
INSERT INTO `grades` VALUES (336, 95, 64, 14);
INSERT INTO `grades` VALUES (337, 47, 14, 8);
INSERT INTO `grades` VALUES (338, 76, 45, 98);
INSERT INTO `grades` VALUES (339, 13, 9, 94);
INSERT INTO `grades` VALUES (340, 79, 90, 51);
INSERT INTO `grades` VALUES (341, 31, 77, 41);
INSERT INTO `grades` VALUES (342, 80, 1, 66);
INSERT INTO `grades` VALUES (343, 6, 47, 31);
INSERT INTO `grades` VALUES (344, 93, 98, 44);
INSERT INTO `grades` VALUES (345, 9, 11, 92);
INSERT INTO `grades` VALUES (346, 94, 28, 11);
INSERT INTO `grades` VALUES (347, 77, 35, 11);
INSERT INTO `grades` VALUES (348, 82, 65, 42);
INSERT INTO `grades` VALUES (349, 92, 56, 50);
INSERT INTO `grades` VALUES (350, 20, 15, 9);
INSERT INTO `grades` VALUES (351, 58, 88, 5);
INSERT INTO `grades` VALUES (352, 59, 34, 64);
INSERT INTO `grades` VALUES (353, 55, 5, 73);
INSERT INTO `grades` VALUES (354, 59, 37, 11);
INSERT INTO `grades` VALUES (355, 36, 12, 80);
INSERT INTO `grades` VALUES (356, 24, 41, 45);
INSERT INTO `grades` VALUES (357, 2, 6, 0);
INSERT INTO `grades` VALUES (358, 62, 12, 62);
INSERT INTO `grades` VALUES (359, 43, 86, 37);
INSERT INTO `grades` VALUES (360, 94, 49, 1);
INSERT INTO `grades` VALUES (361, 69, 34, 97);
INSERT INTO `grades` VALUES (362, 8, 65, 36);
INSERT INTO `grades` VALUES (363, 93, 10, 11);
INSERT INTO `grades` VALUES (364, 96, 16, 69);
INSERT INTO `grades` VALUES (365, 74, 22, 85);
INSERT INTO `grades` VALUES (366, 87, 29, 57);
INSERT INTO `grades` VALUES (367, 55, 84, 11);
INSERT INTO `grades` VALUES (368, 11, 28, 37);
INSERT INTO `grades` VALUES (369, 14, 9, 46);
INSERT INTO `grades` VALUES (370, 76, 32, 0);
INSERT INTO `grades` VALUES (371, 27, 19, 54);
INSERT INTO `grades` VALUES (372, 80, 53, 74);
INSERT INTO `grades` VALUES (373, 42, 36, 16);
INSERT INTO `grades` VALUES (374, 80, 6, 25);
INSERT INTO `grades` VALUES (375, 97, 79, 29);
INSERT INTO `grades` VALUES (376, 53, 82, 92);
INSERT INTO `grades` VALUES (377, 90, 22, 44);
INSERT INTO `grades` VALUES (378, 27, 4, 60);
INSERT INTO `grades` VALUES (379, 4, 73, 2);
INSERT INTO `grades` VALUES (380, 72, 78, 23);
INSERT INTO `grades` VALUES (381, 35, 79, 15);
INSERT INTO `grades` VALUES (382, 68, 56, 16);
INSERT INTO `grades` VALUES (383, 35, 23, 50);
INSERT INTO `grades` VALUES (384, 66, 81, 93);
INSERT INTO `grades` VALUES (385, 17, 19, 64);
INSERT INTO `grades` VALUES (386, 60, 86, 25);
INSERT INTO `grades` VALUES (387, 76, 90, 41);
INSERT INTO `grades` VALUES (388, 18, 19, 80);
INSERT INTO `grades` VALUES (389, 43, 16, 96);
INSERT INTO `grades` VALUES (390, 9, 5, 11);
INSERT INTO `grades` VALUES (391, 13, 52, 58);
INSERT INTO `grades` VALUES (392, 57, 10, 49);
INSERT INTO `grades` VALUES (393, 73, 1, 85);
INSERT INTO `grades` VALUES (394, 35, 78, 63);
INSERT INTO `grades` VALUES (395, 26, 84, 59);
INSERT INTO `grades` VALUES (396, 36, 16, 78);
INSERT INTO `grades` VALUES (397, 81, 53, 51);
INSERT INTO `grades` VALUES (398, 94, 19, 98);
INSERT INTO `grades` VALUES (399, 33, 94, 48);
INSERT INTO `grades` VALUES (400, 60, 10, 29);
INSERT INTO `grades` VALUES (401, 100, 20, 7);
INSERT INTO `grades` VALUES (402, 81, 48, 28);
INSERT INTO `grades` VALUES (403, 8, 85, 17);
INSERT INTO `grades` VALUES (404, 59, 33, 88);
INSERT INTO `grades` VALUES (405, 45, 6, 57);
INSERT INTO `grades` VALUES (406, 79, 10, 31);
INSERT INTO `grades` VALUES (407, 70, 52, 78);
INSERT INTO `grades` VALUES (408, 42, 65, 95);
INSERT INTO `grades` VALUES (409, 55, 62, 26);
INSERT INTO `grades` VALUES (410, 12, 38, 5);
INSERT INTO `grades` VALUES (411, 10, 23, 93);
INSERT INTO `grades` VALUES (412, 98, 50, 52);
INSERT INTO `grades` VALUES (413, 94, 22, 38);
INSERT INTO `grades` VALUES (414, 25, 58, 68);
INSERT INTO `grades` VALUES (415, 40, 31, 69);
INSERT INTO `grades` VALUES (416, 91, 26, 55);
INSERT INTO `grades` VALUES (417, 77, 15, 41);
INSERT INTO `grades` VALUES (418, 6, 70, 18);
INSERT INTO `grades` VALUES (419, 73, 57, 92);
INSERT INTO `grades` VALUES (420, 67, 11, 87);
INSERT INTO `grades` VALUES (421, 18, 58, 47);
INSERT INTO `grades` VALUES (422, 48, 76, 58);
INSERT INTO `grades` VALUES (423, 0, 85, 62);
INSERT INTO `grades` VALUES (424, 42, 11, 63);
INSERT INTO `grades` VALUES (425, 52, 79, 72);
INSERT INTO `grades` VALUES (426, 34, 60, 96);
INSERT INTO `grades` VALUES (427, 27, 79, 49);
INSERT INTO `grades` VALUES (428, 34, 3, 67);
INSERT INTO `grades` VALUES (429, 56, 62, 25);
INSERT INTO `grades` VALUES (430, 80, 15, 92);
INSERT INTO `grades` VALUES (431, 46, 37, 100);
INSERT INTO `grades` VALUES (432, 2, 98, 67);
INSERT INTO `grades` VALUES (433, 81, 22, 2);
INSERT INTO `grades` VALUES (434, 70, 60, 8);
INSERT INTO `grades` VALUES (435, 90, 6, 74);
INSERT INTO `grades` VALUES (436, 78, 40, 70);
INSERT INTO `grades` VALUES (437, 92, 97, 54);
INSERT INTO `grades` VALUES (438, 65, 20, 47);
INSERT INTO `grades` VALUES (439, 41, 32, 96);
INSERT INTO `grades` VALUES (440, 7, 93, 11);
INSERT INTO `grades` VALUES (441, 88, 52, 41);
INSERT INTO `grades` VALUES (442, 86, 22, 43);
INSERT INTO `grades` VALUES (443, 82, 78, 86);
INSERT INTO `grades` VALUES (444, 41, 20, 4);
INSERT INTO `grades` VALUES (445, 46, 65, 70);
INSERT INTO `grades` VALUES (446, 86, 1, 40);
INSERT INTO `grades` VALUES (447, 59, 67, 60);
INSERT INTO `grades` VALUES (448, 30, 59, 62);
INSERT INTO `grades` VALUES (449, 47, 0, 33);
INSERT INTO `grades` VALUES (450, 27, 96, 74);
INSERT INTO `grades` VALUES (451, 57, 14, 2);
INSERT INTO `grades` VALUES (452, 71, 39, 28);
INSERT INTO `grades` VALUES (453, 67, 47, 40);
INSERT INTO `grades` VALUES (454, 63, 37, 47);
INSERT INTO `grades` VALUES (455, 89, 44, 51);
INSERT INTO `grades` VALUES (456, 68, 84, 56);
INSERT INTO `grades` VALUES (457, 78, 43, 9);
INSERT INTO `grades` VALUES (458, 42, 50, 80);
INSERT INTO `grades` VALUES (459, 91, 44, 66);
INSERT INTO `grades` VALUES (460, 43, 72, 98);
INSERT INTO `grades` VALUES (461, 42, 65, 48);
INSERT INTO `grades` VALUES (462, 54, 88, 99);
INSERT INTO `grades` VALUES (463, 38, 41, 22);
INSERT INTO `grades` VALUES (464, 66, 53, 27);
INSERT INTO `grades` VALUES (465, 99, 27, 0);
INSERT INTO `grades` VALUES (466, 6, 55, 5);
INSERT INTO `grades` VALUES (467, 36, 30, 95);
INSERT INTO `grades` VALUES (468, 37, 47, 18);
INSERT INTO `grades` VALUES (469, 17, 22, 51);
INSERT INTO `grades` VALUES (470, 52, 56, 52);
INSERT INTO `grades` VALUES (471, 31, 51, 42);
INSERT INTO `grades` VALUES (472, 28, 17, 49);
INSERT INTO `grades` VALUES (473, 38, 34, 0);
INSERT INTO `grades` VALUES (474, 67, 28, 49);
INSERT INTO `grades` VALUES (475, 63, 19, 24);
INSERT INTO `grades` VALUES (476, 46, 68, 37);
INSERT INTO `grades` VALUES (477, 46, 2, 21);
INSERT INTO `grades` VALUES (478, 93, 49, 34);
INSERT INTO `grades` VALUES (479, 49, 93, 85);
INSERT INTO `grades` VALUES (480, 82, 86, 41);
INSERT INTO `grades` VALUES (481, 38, 77, 29);
INSERT INTO `grades` VALUES (482, 73, 2, 60);
INSERT INTO `grades` VALUES (483, 98, 43, 64);
INSERT INTO `grades` VALUES (484, 23, 51, 88);
INSERT INTO `grades` VALUES (485, 2, 37, 89);
INSERT INTO `grades` VALUES (486, 82, 85, 3);
INSERT INTO `grades` VALUES (487, 56, 1, 42);
INSERT INTO `grades` VALUES (488, 22, 3, 62);
INSERT INTO `grades` VALUES (489, 72, 1, 21);
INSERT INTO `grades` VALUES (490, 78, 21, 51);
INSERT INTO `grades` VALUES (491, 95, 9, 32);
INSERT INTO `grades` VALUES (492, 39, 17, 32);
INSERT INTO `grades` VALUES (493, 39, 19, 74);
INSERT INTO `grades` VALUES (494, 22, 85, 84);
INSERT INTO `grades` VALUES (495, 91, 7, 56);
INSERT INTO `grades` VALUES (496, 95, 51, 68);
INSERT INTO `grades` VALUES (497, 12, 11, 54);
INSERT INTO `grades` VALUES (498, 88, 36, 6);
INSERT INTO `grades` VALUES (499, 6, 39, 70);
INSERT INTO `grades` VALUES (500, 22, 23, 28);
INSERT INTO `grades` VALUES (501, 24, 71, 17);
INSERT INTO `grades` VALUES (502, 67, 37, 25);
INSERT INTO `grades` VALUES (503, 62, 6, 10);
INSERT INTO `grades` VALUES (504, 1, 10, 97);
INSERT INTO `grades` VALUES (505, 34, 6, 41);
INSERT INTO `grades` VALUES (506, 100, 45, 59);
INSERT INTO `grades` VALUES (507, 9, 67, 58);
INSERT INTO `grades` VALUES (508, 7, 51, 2);
INSERT INTO `grades` VALUES (509, 76, 38, 55);
INSERT INTO `grades` VALUES (510, 50, 61, 57);
INSERT INTO `grades` VALUES (511, 83, 32, 83);
INSERT INTO `grades` VALUES (512, 65, 78, 100);
INSERT INTO `grades` VALUES (513, 59, 94, 23);
INSERT INTO `grades` VALUES (514, 76, 23, 73);
INSERT INTO `grades` VALUES (515, 78, 62, 75);
INSERT INTO `grades` VALUES (516, 35, 2, 10);
INSERT INTO `grades` VALUES (517, 79, 13, 14);
INSERT INTO `grades` VALUES (518, 48, 34, 50);
INSERT INTO `grades` VALUES (519, 23, 1, 36);
INSERT INTO `grades` VALUES (520, 41, 83, 81);
INSERT INTO `grades` VALUES (521, 100, 58, 81);
INSERT INTO `grades` VALUES (522, 67, 22, 93);
INSERT INTO `grades` VALUES (523, 96, 57, 55);
INSERT INTO `grades` VALUES (524, 92, 9, 58);
INSERT INTO `grades` VALUES (525, 86, 33, 71);
INSERT INTO `grades` VALUES (526, 56, 48, 80);
INSERT INTO `grades` VALUES (527, 40, 30, 96);
INSERT INTO `grades` VALUES (528, 65, 61, 43);
INSERT INTO `grades` VALUES (529, 21, 50, 77);
INSERT INTO `grades` VALUES (530, 95, 5, 80);
INSERT INTO `grades` VALUES (531, 88, 60, 87);
INSERT INTO `grades` VALUES (532, 53, 83, 19);
INSERT INTO `grades` VALUES (533, 63, 19, 98);
INSERT INTO `grades` VALUES (534, 90, 13, 54);
INSERT INTO `grades` VALUES (535, 32, 27, 71);
INSERT INTO `grades` VALUES (536, 70, 0, 56);
INSERT INTO `grades` VALUES (537, 76, 0, 3);
INSERT INTO `grades` VALUES (538, 28, 12, 46);
INSERT INTO `grades` VALUES (539, 87, 59, 54);
INSERT INTO `grades` VALUES (540, 62, 61, 40);
INSERT INTO `grades` VALUES (541, 7, 47, 35);
INSERT INTO `grades` VALUES (542, 36, 30, 53);
INSERT INTO `grades` VALUES (543, 83, 82, 46);
INSERT INTO `grades` VALUES (544, 81, 2, 89);
INSERT INTO `grades` VALUES (545, 33, 50, 25);
INSERT INTO `grades` VALUES (546, 22, 77, 67);
INSERT INTO `grades` VALUES (547, 49, 6, 8);
INSERT INTO `grades` VALUES (548, 77, 73, 90);
INSERT INTO `grades` VALUES (549, 27, 10, 94);
INSERT INTO `grades` VALUES (550, 84, 92, 67);
INSERT INTO `grades` VALUES (551, 75, 44, 57);
INSERT INTO `grades` VALUES (552, 83, 82, 93);
INSERT INTO `grades` VALUES (553, 62, 80, 76);
INSERT INTO `grades` VALUES (554, 27, 27, 70);
INSERT INTO `grades` VALUES (555, 81, 32, 5);
INSERT INTO `grades` VALUES (556, 25, 17, 27);
INSERT INTO `grades` VALUES (557, 40, 99, 48);
INSERT INTO `grades` VALUES (558, 44, 70, 32);
INSERT INTO `grades` VALUES (559, 99, 43, 31);
INSERT INTO `grades` VALUES (560, 80, 80, 3);
INSERT INTO `grades` VALUES (561, 74, 61, 66);
INSERT INTO `grades` VALUES (562, 81, 6, 45);
INSERT INTO `grades` VALUES (563, 75, 66, 32);
INSERT INTO `grades` VALUES (564, 73, 34, 21);
INSERT INTO `grades` VALUES (565, 45, 61, 93);
INSERT INTO `grades` VALUES (566, 46, 82, 16);
INSERT INTO `grades` VALUES (567, 13, 83, 1);
INSERT INTO `grades` VALUES (568, 44, 4, 76);
INSERT INTO `grades` VALUES (569, 56, 11, 30);
INSERT INTO `grades` VALUES (570, 52, 6, 25);
INSERT INTO `grades` VALUES (571, 19, 38, 41);
INSERT INTO `grades` VALUES (572, 47, 83, 98);
INSERT INTO `grades` VALUES (573, 41, 32, 36);
INSERT INTO `grades` VALUES (574, 47, 76, 58);
INSERT INTO `grades` VALUES (575, 15, 62, 71);
INSERT INTO `grades` VALUES (576, 35, 54, 90);
INSERT INTO `grades` VALUES (577, 0, 59, 83);
INSERT INTO `grades` VALUES (578, 65, 58, 79);
INSERT INTO `grades` VALUES (579, 75, 7, 62);
INSERT INTO `grades` VALUES (580, 94, 0, 44);
INSERT INTO `grades` VALUES (581, 32, 46, 15);
INSERT INTO `grades` VALUES (582, 20, 12, 45);
INSERT INTO `grades` VALUES (583, 56, 6, 8);
INSERT INTO `grades` VALUES (584, 7, 4, 55);
INSERT INTO `grades` VALUES (585, 13, 21, 71);
INSERT INTO `grades` VALUES (586, 96, 53, 0);
INSERT INTO `grades` VALUES (587, 27, 69, 81);
INSERT INTO `grades` VALUES (588, 1, 18, 48);
INSERT INTO `grades` VALUES (589, 58, 28, 65);
INSERT INTO `grades` VALUES (590, 5, 69, 11);
INSERT INTO `grades` VALUES (591, 52, 2, 32);
INSERT INTO `grades` VALUES (592, 59, 58, 25);
INSERT INTO `grades` VALUES (593, 91, 70, 4);
INSERT INTO `grades` VALUES (594, 50, 23, 14);
INSERT INTO `grades` VALUES (595, 12, 50, 29);
INSERT INTO `grades` VALUES (596, 48, 80, 93);
INSERT INTO `grades` VALUES (597, 23, 49, 18);
INSERT INTO `grades` VALUES (598, 62, 7, 35);
INSERT INTO `grades` VALUES (599, 38, 57, 16);
INSERT INTO `grades` VALUES (600, 83, 37, 15);
INSERT INTO `grades` VALUES (601, 38, 54, 24);
INSERT INTO `grades` VALUES (602, 97, 86, 99);
INSERT INTO `grades` VALUES (603, 17, 15, 86);
INSERT INTO `grades` VALUES (604, 28, 54, 26);
INSERT INTO `grades` VALUES (605, 39, 30, 51);
INSERT INTO `grades` VALUES (606, 53, 85, 83);
INSERT INTO `grades` VALUES (607, 20, 67, 68);
INSERT INTO `grades` VALUES (608, 20, 79, 22);
INSERT INTO `grades` VALUES (609, 84, 11, 44);
INSERT INTO `grades` VALUES (610, 29, 10, 8);
INSERT INTO `grades` VALUES (611, 39, 72, 64);
INSERT INTO `grades` VALUES (612, 52, 75, 46);
INSERT INTO `grades` VALUES (613, 20, 7, 14);
INSERT INTO `grades` VALUES (614, 5, 44, 15);
INSERT INTO `grades` VALUES (615, 31, 35, 55);
INSERT INTO `grades` VALUES (616, 71, 59, 14);
INSERT INTO `grades` VALUES (617, 36, 94, 2);
INSERT INTO `grades` VALUES (618, 67, 10, 47);
INSERT INTO `grades` VALUES (619, 10, 82, 2);
INSERT INTO `grades` VALUES (620, 98, 34, 21);
INSERT INTO `grades` VALUES (621, 95, 75, 84);
INSERT INTO `grades` VALUES (622, 38, 98, 52);
INSERT INTO `grades` VALUES (623, 8, 27, 50);
INSERT INTO `grades` VALUES (624, 4, 53, 60);
INSERT INTO `grades` VALUES (625, 64, 72, 76);
INSERT INTO `grades` VALUES (626, 9, 91, 54);
INSERT INTO `grades` VALUES (627, 63, 52, 57);
INSERT INTO `grades` VALUES (628, 4, 84, 16);
INSERT INTO `grades` VALUES (629, 71, 59, 51);
INSERT INTO `grades` VALUES (630, 84, 25, 59);
INSERT INTO `grades` VALUES (631, 4, 3, 100);
INSERT INTO `grades` VALUES (632, 15, 58, 40);
INSERT INTO `grades` VALUES (633, 91, 26, 33);
INSERT INTO `grades` VALUES (634, 80, 42, 57);
INSERT INTO `grades` VALUES (635, 3, 29, 95);
INSERT INTO `grades` VALUES (636, 76, 63, 49);
INSERT INTO `grades` VALUES (637, 98, 35, 59);
INSERT INTO `grades` VALUES (638, 92, 95, 74);
INSERT INTO `grades` VALUES (639, 34, 75, 72);
INSERT INTO `grades` VALUES (640, 100, 64, 3);
INSERT INTO `grades` VALUES (641, 36, 71, 32);
INSERT INTO `grades` VALUES (642, 82, 5, 6);
INSERT INTO `grades` VALUES (643, 6, 58, 77);
INSERT INTO `grades` VALUES (644, 29, 67, 40);
INSERT INTO `grades` VALUES (645, 86, 61, 69);
INSERT INTO `grades` VALUES (646, 90, 43, 92);
INSERT INTO `grades` VALUES (647, 90, 71, 2);
INSERT INTO `grades` VALUES (648, 18, 21, 28);
INSERT INTO `grades` VALUES (649, 87, 43, 10);
INSERT INTO `grades` VALUES (650, 71, 27, 35);
INSERT INTO `grades` VALUES (651, 22, 81, 87);
INSERT INTO `grades` VALUES (652, 89, 41, 18);
INSERT INTO `grades` VALUES (653, 24, 22, 58);
INSERT INTO `grades` VALUES (654, 87, 12, 67);
INSERT INTO `grades` VALUES (655, 14, 86, 76);
INSERT INTO `grades` VALUES (656, 85, 68, 71);
INSERT INTO `grades` VALUES (657, 44, 17, 69);
INSERT INTO `grades` VALUES (658, 87, 22, 79);
INSERT INTO `grades` VALUES (659, 0, 8, 81);
INSERT INTO `grades` VALUES (660, 9, 45, 35);
INSERT INTO `grades` VALUES (661, 68, 15, 2);
INSERT INTO `grades` VALUES (662, 63, 77, 6);
INSERT INTO `grades` VALUES (663, 41, 94, 59);
INSERT INTO `grades` VALUES (664, 53, 11, 91);
INSERT INTO `grades` VALUES (665, 90, 81, 60);
INSERT INTO `grades` VALUES (666, 4, 6, 63);
INSERT INTO `grades` VALUES (667, 61, 42, 61);
INSERT INTO `grades` VALUES (668, 62, 14, 39);
INSERT INTO `grades` VALUES (669, 26, 4, 84);
INSERT INTO `grades` VALUES (670, 7, 22, 45);
INSERT INTO `grades` VALUES (671, 96, 66, 9);
INSERT INTO `grades` VALUES (672, 38, 59, 24);
INSERT INTO `grades` VALUES (673, 98, 11, 77);
INSERT INTO `grades` VALUES (674, 50, 3, 64);
INSERT INTO `grades` VALUES (675, 0, 88, 45);
INSERT INTO `grades` VALUES (676, 12, 21, 26);
INSERT INTO `grades` VALUES (677, 46, 26, 7);
INSERT INTO `grades` VALUES (678, 73, 96, 63);
INSERT INTO `grades` VALUES (679, 29, 65, 48);
INSERT INTO `grades` VALUES (680, 42, 89, 62);
INSERT INTO `grades` VALUES (681, 25, 78, 73);
INSERT INTO `grades` VALUES (682, 37, 74, 85);
INSERT INTO `grades` VALUES (683, 64, 28, 40);
INSERT INTO `grades` VALUES (684, 10, 73, 90);
INSERT INTO `grades` VALUES (685, 21, 61, 26);
INSERT INTO `grades` VALUES (686, 82, 3, 94);
INSERT INTO `grades` VALUES (687, 95, 90, 32);
INSERT INTO `grades` VALUES (688, 86, 83, 62);
INSERT INTO `grades` VALUES (689, 10, 31, 69);
INSERT INTO `grades` VALUES (690, 69, 47, 70);
INSERT INTO `grades` VALUES (691, 20, 33, 4);
INSERT INTO `grades` VALUES (692, 28, 6, 62);
INSERT INTO `grades` VALUES (693, 71, 83, 76);
INSERT INTO `grades` VALUES (694, 1, 18, 27);
INSERT INTO `grades` VALUES (695, 79, 95, 22);
INSERT INTO `grades` VALUES (696, 65, 25, 84);
INSERT INTO `grades` VALUES (697, 39, 40, 23);
INSERT INTO `grades` VALUES (698, 23, 16, 30);
INSERT INTO `grades` VALUES (699, 81, 4, 44);
INSERT INTO `grades` VALUES (700, 10, 35, 79);
INSERT INTO `grades` VALUES (701, 73, 100, 26);
INSERT INTO `grades` VALUES (702, 86, 1, 89);
INSERT INTO `grades` VALUES (703, 34, 22, 33);
INSERT INTO `grades` VALUES (704, 77, 89, 79);
INSERT INTO `grades` VALUES (705, 34, 3, 91);
INSERT INTO `grades` VALUES (706, 62, 32, 68);
INSERT INTO `grades` VALUES (707, 15, 58, 68);
INSERT INTO `grades` VALUES (708, 36, 25, 47);
INSERT INTO `grades` VALUES (709, 59, 46, 88);
INSERT INTO `grades` VALUES (710, 65, 21, 17);
INSERT INTO `grades` VALUES (711, 32, 62, 90);
INSERT INTO `grades` VALUES (712, 36, 72, 47);
INSERT INTO `grades` VALUES (713, 45, 42, 15);
INSERT INTO `grades` VALUES (714, 54, 100, 69);
INSERT INTO `grades` VALUES (715, 28, 20, 62);
INSERT INTO `grades` VALUES (716, 84, 52, 20);
INSERT INTO `grades` VALUES (717, 74, 36, 99);
INSERT INTO `grades` VALUES (718, 24, 54, 46);
INSERT INTO `grades` VALUES (719, 10, 18, 81);
INSERT INTO `grades` VALUES (720, 14, 28, 25);
INSERT INTO `grades` VALUES (721, 8, 57, 54);
INSERT INTO `grades` VALUES (722, 12, 96, 66);
INSERT INTO `grades` VALUES (723, 51, 50, 2);
INSERT INTO `grades` VALUES (724, 6, 52, 16);
INSERT INTO `grades` VALUES (725, 55, 0, 47);
INSERT INTO `grades` VALUES (726, 30, 100, 75);
INSERT INTO `grades` VALUES (727, 42, 0, 42);
INSERT INTO `grades` VALUES (728, 38, 22, 38);
INSERT INTO `grades` VALUES (729, 32, 58, 25);
INSERT INTO `grades` VALUES (730, 58, 41, 100);
INSERT INTO `grades` VALUES (731, 15, 34, 72);
INSERT INTO `grades` VALUES (732, 94, 40, 79);
INSERT INTO `grades` VALUES (733, 52, 78, 88);
INSERT INTO `grades` VALUES (734, 44, 97, 61);
INSERT INTO `grades` VALUES (735, 23, 49, 85);
INSERT INTO `grades` VALUES (736, 65, 67, 75);
INSERT INTO `grades` VALUES (737, 66, 46, 74);
INSERT INTO `grades` VALUES (738, 51, 78, 64);
INSERT INTO `grades` VALUES (739, 53, 23, 45);
INSERT INTO `grades` VALUES (740, 38, 35, 49);
INSERT INTO `grades` VALUES (741, 35, 32, 69);
INSERT INTO `grades` VALUES (742, 3, 8, 52);
INSERT INTO `grades` VALUES (743, 22, 11, 31);
INSERT INTO `grades` VALUES (744, 1, 66, 63);
INSERT INTO `grades` VALUES (745, 48, 38, 24);
INSERT INTO `grades` VALUES (746, 92, 66, 60);
INSERT INTO `grades` VALUES (747, 92, 45, 64);
INSERT INTO `grades` VALUES (748, 56, 83, 2);
INSERT INTO `grades` VALUES (749, 32, 69, 76);
INSERT INTO `grades` VALUES (750, 28, 97, 32);
INSERT INTO `grades` VALUES (751, 19, 1, 20);
INSERT INTO `grades` VALUES (752, 78, 81, 88);
INSERT INTO `grades` VALUES (753, 2, 90, 75);
INSERT INTO `grades` VALUES (754, 90, 56, 41);
INSERT INTO `grades` VALUES (755, 86, 87, 63);
INSERT INTO `grades` VALUES (756, 36, 15, 96);
INSERT INTO `grades` VALUES (757, 7, 21, 24);
INSERT INTO `grades` VALUES (758, 53, 6, 21);
INSERT INTO `grades` VALUES (759, 67, 85, 79);
INSERT INTO `grades` VALUES (760, 66, 90, 66);
INSERT INTO `grades` VALUES (761, 26, 12, 47);
INSERT INTO `grades` VALUES (762, 87, 68, 71);
INSERT INTO `grades` VALUES (763, 60, 7, 42);
INSERT INTO `grades` VALUES (764, 52, 81, 9);
INSERT INTO `grades` VALUES (765, 76, 29, 20);
INSERT INTO `grades` VALUES (766, 69, 61, 72);
INSERT INTO `grades` VALUES (767, 28, 28, 58);
INSERT INTO `grades` VALUES (768, 3, 61, 93);
INSERT INTO `grades` VALUES (769, 20, 28, 47);
INSERT INTO `grades` VALUES (770, 39, 88, 86);
INSERT INTO `grades` VALUES (771, 23, 16, 60);
INSERT INTO `grades` VALUES (772, 22, 64, 77);
INSERT INTO `grades` VALUES (773, 45, 82, 31);
INSERT INTO `grades` VALUES (774, 86, 30, 13);
INSERT INTO `grades` VALUES (775, 22, 24, 86);
INSERT INTO `grades` VALUES (776, 58, 93, 80);
INSERT INTO `grades` VALUES (777, 29, 49, 43);
INSERT INTO `grades` VALUES (778, 32, 90, 82);
INSERT INTO `grades` VALUES (779, 44, 28, 58);
INSERT INTO `grades` VALUES (780, 95, 84, 92);
INSERT INTO `grades` VALUES (781, 94, 83, 76);
INSERT INTO `grades` VALUES (782, 25, 84, 38);
INSERT INTO `grades` VALUES (783, 63, 4, 30);
INSERT INTO `grades` VALUES (784, 33, 83, 5);
INSERT INTO `grades` VALUES (785, 94, 20, 96);
INSERT INTO `grades` VALUES (786, 89, 8, 65);
INSERT INTO `grades` VALUES (787, 92, 47, 23);
INSERT INTO `grades` VALUES (788, 70, 2, 69);
INSERT INTO `grades` VALUES (789, 33, 0, 83);
INSERT INTO `grades` VALUES (790, 97, 88, 42);
INSERT INTO `grades` VALUES (791, 69, 21, 49);
INSERT INTO `grades` VALUES (792, 64, 14, 69);
INSERT INTO `grades` VALUES (793, 47, 78, 93);
INSERT INTO `grades` VALUES (794, 85, 40, 89);
INSERT INTO `grades` VALUES (795, 50, 78, 55);
INSERT INTO `grades` VALUES (796, 72, 57, 25);
INSERT INTO `grades` VALUES (797, 76, 71, 82);
INSERT INTO `grades` VALUES (798, 56, 95, 20);
INSERT INTO `grades` VALUES (799, 100, 11, 34);
INSERT INTO `grades` VALUES (800, 9, 19, 75);
INSERT INTO `grades` VALUES (801, 85, 42, 66);
INSERT INTO `grades` VALUES (802, 97, 47, 73);
INSERT INTO `grades` VALUES (803, 5, 37, 79);
INSERT INTO `grades` VALUES (804, 2, 49, 50);
INSERT INTO `grades` VALUES (805, 57, 23, 80);
INSERT INTO `grades` VALUES (806, 12, 17, 12);
INSERT INTO `grades` VALUES (807, 9, 35, 97);
INSERT INTO `grades` VALUES (808, 67, 4, 31);
INSERT INTO `grades` VALUES (809, 66, 89, 38);
INSERT INTO `grades` VALUES (810, 32, 24, 15);
INSERT INTO `grades` VALUES (811, 35, 0, 64);
INSERT INTO `grades` VALUES (812, 88, 49, 12);
INSERT INTO `grades` VALUES (813, 16, 25, 2);
INSERT INTO `grades` VALUES (814, 22, 73, 51);
INSERT INTO `grades` VALUES (815, 66, 65, 10);
INSERT INTO `grades` VALUES (816, 24, 88, 16);
INSERT INTO `grades` VALUES (817, 42, 95, 54);
INSERT INTO `grades` VALUES (818, 23, 90, 5);
INSERT INTO `grades` VALUES (819, 71, 60, 88);
INSERT INTO `grades` VALUES (820, 16, 56, 0);
INSERT INTO `grades` VALUES (821, 48, 9, 22);
INSERT INTO `grades` VALUES (822, 64, 1, 14);
INSERT INTO `grades` VALUES (823, 83, 73, 34);
INSERT INTO `grades` VALUES (824, 37, 68, 25);
INSERT INTO `grades` VALUES (825, 47, 19, 27);
INSERT INTO `grades` VALUES (826, 69, 12, 15);
INSERT INTO `grades` VALUES (827, 73, 60, 95);
INSERT INTO `grades` VALUES (828, 70, 67, 24);
INSERT INTO `grades` VALUES (829, 48, 90, 75);
INSERT INTO `grades` VALUES (830, 97, 79, 6);
INSERT INTO `grades` VALUES (831, 98, 91, 0);
INSERT INTO `grades` VALUES (832, 62, 14, 93);
INSERT INTO `grades` VALUES (833, 20, 4, 42);
INSERT INTO `grades` VALUES (834, 61, 0, 72);
INSERT INTO `grades` VALUES (835, 61, 0, 24);
INSERT INTO `grades` VALUES (836, 65, 76, 38);
INSERT INTO `grades` VALUES (837, 57, 59, 77);
INSERT INTO `grades` VALUES (838, 90, 9, 30);
INSERT INTO `grades` VALUES (839, 84, 63, 32);
INSERT INTO `grades` VALUES (840, 64, 17, 3);
INSERT INTO `grades` VALUES (841, 76, 88, 12);
INSERT INTO `grades` VALUES (842, 64, 5, 59);
INSERT INTO `grades` VALUES (843, 3, 58, 95);
INSERT INTO `grades` VALUES (844, 81, 50, 33);
INSERT INTO `grades` VALUES (845, 58, 64, 28);
INSERT INTO `grades` VALUES (846, 0, 87, 98);
INSERT INTO `grades` VALUES (847, 2, 66, 85);
INSERT INTO `grades` VALUES (848, 42, 97, 85);
INSERT INTO `grades` VALUES (849, 59, 46, 6);
INSERT INTO `grades` VALUES (850, 23, 36, 75);
INSERT INTO `grades` VALUES (851, 5, 20, 20);
INSERT INTO `grades` VALUES (852, 58, 60, 56);
INSERT INTO `grades` VALUES (853, 31, 53, 4);
INSERT INTO `grades` VALUES (854, 25, 28, 95);
INSERT INTO `grades` VALUES (855, 9, 91, 63);
INSERT INTO `grades` VALUES (856, 41, 60, 24);
INSERT INTO `grades` VALUES (857, 81, 49, 70);
INSERT INTO `grades` VALUES (858, 39, 94, 63);
INSERT INTO `grades` VALUES (859, 59, 2, 21);
INSERT INTO `grades` VALUES (860, 98, 69, 41);
INSERT INTO `grades` VALUES (861, 99, 49, 28);
INSERT INTO `grades` VALUES (862, 97, 66, 81);
INSERT INTO `grades` VALUES (863, 29, 84, 87);
INSERT INTO `grades` VALUES (864, 52, 43, 14);
INSERT INTO `grades` VALUES (865, 51, 35, 0);
INSERT INTO `grades` VALUES (866, 84, 49, 85);
INSERT INTO `grades` VALUES (867, 52, 16, 39);
INSERT INTO `grades` VALUES (868, 37, 79, 57);
INSERT INTO `grades` VALUES (869, 31, 82, 33);
INSERT INTO `grades` VALUES (870, 14, 57, 1);
INSERT INTO `grades` VALUES (871, 12, 50, 89);
INSERT INTO `grades` VALUES (872, 82, 59, 34);
INSERT INTO `grades` VALUES (873, 5, 75, 83);
INSERT INTO `grades` VALUES (874, 93, 83, 91);
INSERT INTO `grades` VALUES (875, 5, 9, 77);
INSERT INTO `grades` VALUES (876, 10, 18, 82);
INSERT INTO `grades` VALUES (877, 18, 97, 34);
INSERT INTO `grades` VALUES (878, 68, 56, 49);
INSERT INTO `grades` VALUES (879, 72, 55, 88);
INSERT INTO `grades` VALUES (880, 54, 53, 61);
INSERT INTO `grades` VALUES (881, 20, 73, 42);
INSERT INTO `grades` VALUES (882, 22, 36, 73);
INSERT INTO `grades` VALUES (883, 41, 76, 84);
INSERT INTO `grades` VALUES (884, 95, 13, 70);
INSERT INTO `grades` VALUES (885, 43, 97, 2);
INSERT INTO `grades` VALUES (886, 25, 59, 29);
INSERT INTO `grades` VALUES (887, 23, 37, 8);
INSERT INTO `grades` VALUES (888, 30, 99, 49);
INSERT INTO `grades` VALUES (889, 13, 2, 77);
INSERT INTO `grades` VALUES (890, 89, 88, 47);
INSERT INTO `grades` VALUES (891, 57, 74, 56);
INSERT INTO `grades` VALUES (892, 51, 35, 55);
INSERT INTO `grades` VALUES (893, 24, 97, 84);
INSERT INTO `grades` VALUES (894, 6, 31, 70);
INSERT INTO `grades` VALUES (895, 19, 67, 100);
INSERT INTO `grades` VALUES (896, 45, 42, 23);
INSERT INTO `grades` VALUES (897, 1, 18, 43);
INSERT INTO `grades` VALUES (898, 19, 7, 77);
INSERT INTO `grades` VALUES (899, 46, 37, 39);
INSERT INTO `grades` VALUES (900, 12, 51, 68);
INSERT INTO `grades` VALUES (901, 57, 79, 71);
INSERT INTO `grades` VALUES (902, 10, 44, 28);
INSERT INTO `grades` VALUES (903, 0, 65, 53);
INSERT INTO `grades` VALUES (904, 40, 90, 77);
INSERT INTO `grades` VALUES (905, 68, 92, 67);
INSERT INTO `grades` VALUES (906, 27, 39, 84);
INSERT INTO `grades` VALUES (907, 85, 19, 31);
INSERT INTO `grades` VALUES (908, 90, 38, 81);
INSERT INTO `grades` VALUES (909, 72, 34, 17);
INSERT INTO `grades` VALUES (910, 73, 98, 55);
INSERT INTO `grades` VALUES (911, 40, 85, 2);
INSERT INTO `grades` VALUES (912, 92, 22, 75);
INSERT INTO `grades` VALUES (913, 45, 1, 39);
INSERT INTO `grades` VALUES (914, 95, 9, 81);
INSERT INTO `grades` VALUES (915, 47, 18, 88);
INSERT INTO `grades` VALUES (916, 98, 79, 25);
INSERT INTO `grades` VALUES (917, 99, 33, 68);
INSERT INTO `grades` VALUES (918, 8, 93, 32);
INSERT INTO `grades` VALUES (919, 35, 36, 37);
INSERT INTO `grades` VALUES (920, 71, 97, 7);
INSERT INTO `grades` VALUES (921, 23, 76, 10);
INSERT INTO `grades` VALUES (922, 35, 99, 100);
INSERT INTO `grades` VALUES (923, 13, 89, 12);
INSERT INTO `grades` VALUES (924, 87, 22, 6);
INSERT INTO `grades` VALUES (925, 73, 96, 62);
INSERT INTO `grades` VALUES (926, 36, 67, 50);
INSERT INTO `grades` VALUES (927, 30, 93, 64);
INSERT INTO `grades` VALUES (928, 10, 55, 99);
INSERT INTO `grades` VALUES (929, 24, 8, 92);
INSERT INTO `grades` VALUES (930, 42, 29, 5);
INSERT INTO `grades` VALUES (931, 26, 68, 10);
INSERT INTO `grades` VALUES (932, 69, 19, 49);
INSERT INTO `grades` VALUES (933, 67, 95, 64);
INSERT INTO `grades` VALUES (934, 27, 53, 85);
INSERT INTO `grades` VALUES (935, 53, 7, 57);
INSERT INTO `grades` VALUES (936, 45, 34, 61);
INSERT INTO `grades` VALUES (937, 18, 54, 1);
INSERT INTO `grades` VALUES (938, 26, 33, 79);
INSERT INTO `grades` VALUES (939, 28, 28, 56);
INSERT INTO `grades` VALUES (940, 46, 67, 65);
INSERT INTO `grades` VALUES (941, 59, 18, 43);
INSERT INTO `grades` VALUES (942, 9, 39, 28);
INSERT INTO `grades` VALUES (943, 85, 73, 74);
INSERT INTO `grades` VALUES (944, 52, 5, 79);
INSERT INTO `grades` VALUES (945, 26, 97, 20);
INSERT INTO `grades` VALUES (946, 22, 68, 23);
INSERT INTO `grades` VALUES (947, 16, 70, 20);
INSERT INTO `grades` VALUES (948, 21, 83, 65);
INSERT INTO `grades` VALUES (949, 23, 97, 47);
INSERT INTO `grades` VALUES (950, 39, 70, 28);
INSERT INTO `grades` VALUES (951, 13, 87, 10);
INSERT INTO `grades` VALUES (952, 35, 98, 88);
INSERT INTO `grades` VALUES (953, 47, 74, 83);
INSERT INTO `grades` VALUES (954, 59, 66, 28);
INSERT INTO `grades` VALUES (955, 39, 55, 60);
INSERT INTO `grades` VALUES (956, 4, 73, 82);
INSERT INTO `grades` VALUES (957, 16, 29, 34);
INSERT INTO `grades` VALUES (958, 56, 97, 21);
INSERT INTO `grades` VALUES (959, 3, 50, 21);
INSERT INTO `grades` VALUES (960, 5, 14, 82);
INSERT INTO `grades` VALUES (961, 92, 51, 4);
INSERT INTO `grades` VALUES (962, 96, 36, 70);
INSERT INTO `grades` VALUES (963, 12, 82, 57);
INSERT INTO `grades` VALUES (964, 21, 73, 28);
INSERT INTO `grades` VALUES (965, 3, 13, 99);
INSERT INTO `grades` VALUES (966, 3, 77, 96);
INSERT INTO `grades` VALUES (967, 99, 63, 6);
INSERT INTO `grades` VALUES (968, 58, 91, 100);
INSERT INTO `grades` VALUES (969, 40, 22, 49);
INSERT INTO `grades` VALUES (970, 58, 32, 12);
INSERT INTO `grades` VALUES (971, 29, 67, 37);
INSERT INTO `grades` VALUES (972, 51, 50, 53);
INSERT INTO `grades` VALUES (973, 70, 55, 3);
INSERT INTO `grades` VALUES (974, 97, 93, 7);
INSERT INTO `grades` VALUES (975, 83, 40, 80);
INSERT INTO `grades` VALUES (976, 93, 7, 40);
INSERT INTO `grades` VALUES (977, 35, 37, 4);
INSERT INTO `grades` VALUES (978, 32, 59, 21);
INSERT INTO `grades` VALUES (979, 16, 33, 67);
INSERT INTO `grades` VALUES (980, 71, 66, 18);
INSERT INTO `grades` VALUES (981, 64, 69, 32);
INSERT INTO `grades` VALUES (982, 57, 98, 51);
INSERT INTO `grades` VALUES (983, 71, 36, 99);
INSERT INTO `grades` VALUES (984, 80, 61, 92);
INSERT INTO `grades` VALUES (985, 43, 9, 24);
INSERT INTO `grades` VALUES (986, 68, 21, 31);
INSERT INTO `grades` VALUES (987, 78, 33, 2);
INSERT INTO `grades` VALUES (988, 34, 79, 79);
INSERT INTO `grades` VALUES (989, 70, 67, 48);
INSERT INTO `grades` VALUES (990, 40, 69, 91);
INSERT INTO `grades` VALUES (991, 65, 56, 8);
INSERT INTO `grades` VALUES (992, 60, 6, 85);
INSERT INTO `grades` VALUES (993, 25, 74, 60);
INSERT INTO `grades` VALUES (994, 7, 5, 87);
INSERT INTO `grades` VALUES (995, 3, 64, 78);
INSERT INTO `grades` VALUES (996, 69, 100, 80);
INSERT INTO `grades` VALUES (997, 64, 70, 93);
INSERT INTO `grades` VALUES (998, 27, 9, 21);
INSERT INTO `grades` VALUES (999, 42, 28, 86);
INSERT INTO `grades` VALUES (1000, 93, 60, 8);

-- ----------------------------
-- Table structure for userdata
-- ----------------------------
DROP TABLE IF EXISTS `userdata`;
CREATE TABLE `userdata`  (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `position` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `gender` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `university` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 59 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of userdata
-- ----------------------------
INSERT INTO `userdata` VALUES (1, 'Pepe the Frog', 'Junior Programmer', 'Male', 'Jose Rizal Memorial State Unversity');
INSERT INTO `userdata` VALUES (2, 'Gay', 'Structural Analysis ', 'Female', 'Yeshiva University');
INSERT INTO `userdata` VALUES (3, 'Erminia', 'VP Accounting', 'Female', 'Conestoga College');
INSERT INTO `userdata` VALUES (4, 'Si', 'Staff Scientist', 'Male', 'Cape Coast Polytechnic ');
INSERT INTO `userdata` VALUES (5, 'Cyril', 'Accounting Assistant', 'Male', 'Jingdezhen China Institute');
INSERT INTO `userdata` VALUES (6, 'Kerwin', 'Payment Adjustment C', 'Male', 'Kurashiki University of Science and the Arts');
INSERT INTO `userdata` VALUES (7, 'Olenka', 'Chief Design Enginee', 'Female', 'Saint Louis College');
INSERT INTO `userdata` VALUES (8, 'Bobbie', 'Statistician IV', 'Non-binary', 'Qingdao University');
INSERT INTO `userdata` VALUES (9, 'Aarika', 'Administrative Offic', 'Female', 'University of Sopron');
INSERT INTO `userdata` VALUES (10, 'Alverta', 'Nurse', 'Female', 'Harris-Stowe State University');
INSERT INTO `userdata` VALUES (11, 'Ame', 'Health Coach I', 'Female', 'Ecole Supérieure de Commerce de Rouen');
INSERT INTO `userdata` VALUES (12, 'Thomasine', 'Account Representati', 'Female', 'Vitebsk State University');
INSERT INTO `userdata` VALUES (13, 'Jasun', 'Geologist IV', 'Male', 'Himachal Pradesh Agricultural University');
INSERT INTO `userdata` VALUES (14, 'Durant', 'Mechanical Systems E', 'Male', 'Frederick University');
INSERT INTO `userdata` VALUES (15, 'Denver', 'Web Designer I', 'Male', 'Asia University');
INSERT INTO `userdata` VALUES (16, 'Vevay', 'Tax Accountant', 'Female', 'Griffith College');
INSERT INTO `userdata` VALUES (17, 'Bette-ann', 'Sales Associate', 'Female', 'Universidad de Carabobo');
INSERT INTO `userdata` VALUES (18, 'Gretal', 'Account Representati', 'Female', 'Baze University Abuja');
INSERT INTO `userdata` VALUES (19, 'Brant', 'Help Desk Technician', 'Male', 'Chao Yang University of Science and Technology');
INSERT INTO `userdata` VALUES (20, 'Kienan', 'Account Executive', 'Male', 'Dominican College of Philosophy and Theology');
INSERT INTO `userdata` VALUES (21, 'Gallard', 'Systems Administrato', 'Male', 'Kamchatka State University Vitus Bering');
INSERT INTO `userdata` VALUES (22, 'Roslyn', 'Staff Scientist', 'Female', 'Touro College');
INSERT INTO `userdata` VALUES (23, 'Nadiya', 'Help Desk Technician', 'Female', 'University of Southern Mississippi');
INSERT INTO `userdata` VALUES (24, 'Wyatt', 'VP Marketing', 'Male', 'University of Great Falls');
INSERT INTO `userdata` VALUES (25, 'Korey', 'Operator', 'Male', 'Estonian Business School');
INSERT INTO `userdata` VALUES (26, 'Caterina', 'Social Worker', 'Female', 'University of Worcester');
INSERT INTO `userdata` VALUES (27, 'Keely', 'Nuclear Power Engine', 'Female', 'Aalborg Business College');
INSERT INTO `userdata` VALUES (28, 'Myrwyn', 'Actuary', 'Male', 'Arab Open University');
INSERT INTO `userdata` VALUES (29, 'Vasili', 'Quality Control Spec', 'Bigender', 'Southern New Hampshire University');
INSERT INTO `userdata` VALUES (30, 'Findlay', 'Analog Circuit Desig', 'Male', 'Ilsa Independent College');
INSERT INTO `userdata` VALUES (31, 'Siffre', 'Civil Engineer', 'Male', 'German Jordanian University');
INSERT INTO `userdata` VALUES (32, 'Mace', 'Research Assistant I', 'Male', 'Institut Supérieure d\'Electronique du Nord');
INSERT INTO `userdata` VALUES (33, 'Ignatius', 'Biostatistician III', 'Male', 'Spring Hill College');
INSERT INTO `userdata` VALUES (34, 'Quinlan', 'Financial Advisor', 'Male', 'Hanoi Open University');
INSERT INTO `userdata` VALUES (35, 'Sebastien', 'Web Developer I', 'Male', 'Institute of Finance Management');
INSERT INTO `userdata` VALUES (36, 'Lory', 'Research Associate', 'Female', 'Tezukayama University');
INSERT INTO `userdata` VALUES (37, 'Rani', 'Web Developer III', 'Female', 'Jubail Industrial College');
INSERT INTO `userdata` VALUES (38, 'Yard', 'Associate Professor', 'Male', 'Ecole Superieure Robert de Sorbon');
INSERT INTO `userdata` VALUES (39, 'Griffin', 'Mechanical Systems E', 'Male', 'Open University Malaysia');
INSERT INTO `userdata` VALUES (40, 'Batsheva', 'Nurse', 'Bigender', 'Sri Venkateswara University');
INSERT INTO `userdata` VALUES (41, 'Giustina', 'Web Developer IV', 'Female', 'Windsor University School of Medicine');
INSERT INTO `userdata` VALUES (42, 'Anne-corinne', 'Cost Accountant', 'Female', 'Covenant College');
INSERT INTO `userdata` VALUES (43, 'Thadeus', 'Teacher', 'Male', 'Komar University of Science and Technology');
INSERT INTO `userdata` VALUES (44, 'Fan', 'Environmental Tech', 'Female', 'Tongmyung University of Information Technology');
INSERT INTO `userdata` VALUES (45, 'Nester', 'Payment Adjustment C', 'Male', 'Universidad Nacional Pedro Henríquez Ureña');
INSERT INTO `userdata` VALUES (46, 'Dael', 'Senior Cost Accounta', 'Genderquee', 'University of Development Alternative');
INSERT INTO `userdata` VALUES (47, 'Gaspard', 'Assistant Media Plan', 'Male', 'Central Mindanao University');
INSERT INTO `userdata` VALUES (48, 'Edythe', 'Environmental Tech', 'Female', 'Universidade Vale do Paraiba');
INSERT INTO `userdata` VALUES (49, 'Chas', 'Community Outreach S', 'Male', 'Western Kentucky University');
INSERT INTO `userdata` VALUES (50, 'Karalee', 'Senior Financial Ana', 'Genderflui', 'Augustana Hochschule Neuendettelsau');
INSERT INTO `userdata` VALUES (51, 'Jacklyn', 'Actuary', 'Female', 'Medizinische Universität Wien');
INSERT INTO `userdata` VALUES (52, 'Jo Kristein M. Quint', 'Consultant', 'Female', 'Jose Rizal Memorial State Unversity');
INSERT INTO `userdata` VALUES (53, 'Jo Quintero', 'Marketing Specialist', 'Female', 'JRMSU');
INSERT INTO `userdata` VALUES (54, 'Gideon Santiago', 'Software Developer', 'Male', 'Harvard University');
INSERT INTO `userdata` VALUES (55, 'Elon Musk', 'CEO', 'Male', '-');
INSERT INTO `userdata` VALUES (56, 'Mark Zuckerberg', 'CEO', 'Male', 'Harvard University');
INSERT INTO `userdata` VALUES (57, '', '', '', '');
INSERT INTO `userdata` VALUES (58, 'Tiktok', 'Dancer', 'Neutrak', 'TIKTOK U');

-- ----------------------------
-- Function structure for calculate_average_grade
-- ----------------------------
DROP FUNCTION IF EXISTS `calculate_average_grade`;
delimiter ;;
CREATE FUNCTION `calculate_average_grade`(`student_id` INT)
 RETURNS decimal(5,0)
BEGIN
    DECLARE total_grade DECIMAL(5, 2);

    -- Calculate total grade for the given student
    SELECT AVG((subject1 + subject2 + subject3) / 3) INTO total_grade
    FROM grades
    WHERE student_id = student_id;

    -- Return the average grade
    RETURN IFNULL(total_grade, 0);
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for create_login_acc
-- ----------------------------
DROP PROCEDURE IF EXISTS `create_login_acc`;
delimiter ;;
CREATE PROCEDURE `create_login_acc`(IN `fusername` VARCHAR(20), IN `fpassword` VARCHAR(20))
INSERT INTO login(login.username,login.password) VALUES(fusername,fpassword)
;;
delimiter ;

-- ----------------------------
-- Procedure structure for delete
-- ----------------------------
DROP PROCEDURE IF EXISTS `delete`;
delimiter ;;
CREATE PROCEDURE `delete`(IN `id1` INT(20))
DELETE  FROM employees WHERE employees.employee_id = id1
;;
delimiter ;

-- ----------------------------
-- Procedure structure for display
-- ----------------------------
DROP PROCEDURE IF EXISTS `display`;
delimiter ;;
CREATE PROCEDURE `display`(IN `id` VARCHAR(21))
SELECT * FROM employees WHERE employee_id = id
;;
delimiter ;

-- ----------------------------
-- Procedure structure for getSingleUser
-- ----------------------------
DROP PROCEDURE IF EXISTS `getSingleUser`;
delimiter ;;
CREATE PROCEDURE `getSingleUser`(IN `userID` INT)
SELECT * FROM userdata WHERE userdata.id = userID
;;
delimiter ;

-- ----------------------------
-- Procedure structure for readUserData
-- ----------------------------
DROP PROCEDURE IF EXISTS `readUserData`;
delimiter ;;
CREATE PROCEDURE `readUserData`()
SELECT * FROM userdata
;;
delimiter ;

-- ----------------------------
-- Procedure structure for read_grades
-- ----------------------------
DROP PROCEDURE IF EXISTS `read_grades`;
delimiter ;;
CREATE PROCEDURE `read_grades`()
SELECT * FROM grades
;;
delimiter ;

-- ----------------------------
-- Procedure structure for read_login
-- ----------------------------
DROP PROCEDURE IF EXISTS `read_login`;
delimiter ;;
CREATE PROCEDURE `read_login`()
SELECT * FROM login
;;
delimiter ;

-- ----------------------------
-- Procedure structure for searchEmployee
-- ----------------------------
DROP PROCEDURE IF EXISTS `searchEmployee`;
delimiter ;;
CREATE PROCEDURE `searchEmployee`(IN `keyword` VARCHAR(20))
SELECT * FROM employees WHERE employees.fullname LIKE keyword
;;
delimiter ;

SET FOREIGN_KEY_CHECKS = 1;
