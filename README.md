# Exercise API
This is an API built with ASP.NET Web API and C# that provides common exercises for each major muscle group.

## List all exercises
```
https://localhost:7129/api/exercises
```
```
Response (snippet):

{
    "exerciseId": 1,
    "exerciseName": "Flat barbell bench press"
  },
  {
    "exerciseId": 2,
    "exerciseName": "Incline barbell bench press"
  },
  {
    "exerciseId": 3,
    "exerciseName": "Flat dumbbell bench press"
  },
  {
    "exerciseId": 4,
    "exerciseName": "Incline dumbbell bench press"
  },
  {
    "exerciseId": 5,
    "exerciseName": "Close-grip bench press"
  },
  {
    "exerciseId": 6,
    "exerciseName": "Reverse-grip bench press"
  },
  ...
```


## List all muscle group category
```
https://localhost:7129/api/categories
```
```
Response:
{
    "muscleGroupId": 1,
    "muscleGroupName": "chest"
  },
  {
    "muscleGroupId": 2,
    "muscleGroupName": "back"
  },
  {
    "muscleGroupId": 3,
    "muscleGroupName": "arms"
  },
  {
    "muscleGroupId": 4,
    "muscleGroupName": "shoulders"
  },
  {
    "muscleGroupId": 5,
    "muscleGroupName": "legs"
  },
  {
    "muscleGroupId": 6,
    "muscleGroupName": "calves"
  },
  {
    "muscleGroupId": 7,
    "muscleGroupName": "abdominals"
  }
```

## Search for exercises by muscle group
```
https://localhost:7129/api/exercises/category/chest
```
```
Response:
{
    "exerciseId": 1,
    "exerciseName": "Flat barbell bench press"
  },
  {
    "exerciseId": 2,
    "exerciseName": "Incline barbell bench press"
  },
  {
    "exerciseId": 3,
    "exerciseName": "Flat dumbbell bench press"
  },
  {
    "exerciseId": 4,
    "exerciseName": "Incline dumbbell bench press"
  },
  {
    "exerciseId": 5,
    "exerciseName": "Close-grip bench press"
  },
  {
    "exerciseId": 6,
    "exerciseName": "Reverse-grip bench press"
  },
  {
    "exerciseId": 7,
    "exerciseName": "Dips"
  }
```

