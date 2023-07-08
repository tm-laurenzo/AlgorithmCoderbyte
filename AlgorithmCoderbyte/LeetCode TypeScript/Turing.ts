class TuringPoint{
  x: number;
  y: number;
}

interface Point3d extends TuringPoint{
  z: number;
}

let point3d: Point3d = {x: 3, y:8, z:9};
console.log(point3d);