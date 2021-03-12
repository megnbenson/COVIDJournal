

-- add role
INSERT INTO AspNetRoles(Id, Name)
VALUES (1, 'Administrator');

INSERT INTO AspNetRoles(Id, Name)
VALUES (2, 'User');

-- link existing role to existing user
INSERT INTO AspNetUserRoles(UserId, RoleId)
VALUES ('d9bee125-3d75-49c5-abad-3809e99081ae', 1);

INSERT INTO AspNetUserRoles(UserId, RoleId)
VALUES ('91c5b705-8c36-4409-a2b6-5966dd45e877', 2);



select * from AspNetRoles
select * from AspNetUserRoles
select * from AspNetUsers