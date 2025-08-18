import * as THREE from "three";
import Transforms from "../Utils/Transforms";
import GeometryBuilder from "./GeometryBuilder";
import MaterialBuilder from "./MaterialBuilder";

class PointsBuilder {
  static BuildPoints(options) {
    const geometry = GeometryBuilder.buildGeometry(options.geometry);
    const material = MaterialBuilder.buildMaterial(options.material);
    const points = new THREE.Points(geometry, material);
    points.uuid = options.uuid;

    Transforms.setPosition(points, options.position);
    Transforms.setRotation(points, options.rotation);
    Transforms.setScale(points, options.scale);
    return points;
  }
}

export default PointsBuilder;
