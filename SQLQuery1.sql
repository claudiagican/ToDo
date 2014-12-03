SELECT Projects.* FROM Projects, ProjectUser
WHERE ProjectUser.UID = @0 and ProjectUser.PID=Projects.PID and Projects.IsDeleted=0


CREATE TABLE [dbo].[ProjectUser] (
    [PID] INT NOT NULL,
    [UID] INT NOT NULL
);