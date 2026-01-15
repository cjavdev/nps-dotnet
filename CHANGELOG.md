# Changelog

## 0.5.0 (2026-01-15)

Full Changelog: [v0.4.1...v0.5.0](https://github.com/cjavdev/nps-dotnet/compare/v0.4.1...v0.5.0)

### Features

* **client:** add helper functions for raw messages ([0f0c89a](https://github.com/cjavdev/nps-dotnet/commit/0f0c89ad758d7ecb5e6ac2c39de4a5f662925b41))


### Bug Fixes

* **ci:** don't throw an error about missing lsof ([02c3179](https://github.com/cjavdev/nps-dotnet/commit/02c31791b2c3f6e0248392a7ae39f4925d7876d4))
* **client:** throw api enum errors as invalid data exception ([4b4d65a](https://github.com/cjavdev/nps-dotnet/commit/4b4d65ad1f7e9ae4a19b84c0db7ea91d46910386))


### Chores

* **client:** consistently use serializer options ([0bad921](https://github.com/cjavdev/nps-dotnet/commit/0bad921a699cd897724247218bdd35cc5ee3de83))
* **readme:** remove beta warning now that we're in ga ([d0bdd61](https://github.com/cjavdev/nps-dotnet/commit/d0bdd614ece146f563c0dcf56b8b42400e52d0c9))

## 0.4.1 (2026-01-13)

Full Changelog: [v0.4.0...v0.4.1](https://github.com/cjavdev/nps-dotnet/compare/v0.4.0...v0.4.1)

### Bug Fixes

* **client:** add missing `.Value` ([7f6a6d8](https://github.com/cjavdev/nps-dotnet/commit/7f6a6d8910715661b7b2d0291f4d38fe48f286c0))
* **client:** add missing null check ([ff55619](https://github.com/cjavdev/nps-dotnet/commit/ff55619fea0df67f17dfdbf0a30011e24ee5965f))
* **client:** ensure deep immutability for deep array/dict structures ([aafe46e](https://github.com/cjavdev/nps-dotnet/commit/aafe46e72453391189a5ca713fc95dba7b212d7d))
* **client:** fix type mismatch for nested readonly types ([8fbb05b](https://github.com/cjavdev/nps-dotnet/commit/8fbb05bbe8e9a77f918712e707d3fe5d0c0b7ea0))
* **client:** freeze models on property access ([0e36c2c](https://github.com/cjavdev/nps-dotnet/commit/0e36c2c893097643d7b29314b77816a19c0a0711))
* **client:** incorrect variable reference ([f04c4b2](https://github.com/cjavdev/nps-dotnet/commit/f04c4b2af567b83713f44367b05e62bbd1b72be5))


### Performance Improvements

* **client:** add json deserialization caching ([aafe46e](https://github.com/cjavdev/nps-dotnet/commit/aafe46e72453391189a5ca713fc95dba7b212d7d))


### Chores

* **internal:** codegen related update ([a3a6376](https://github.com/cjavdev/nps-dotnet/commit/a3a6376cba5129fac3f7239bfe78bc9bd88a78f8))


### Refactors

* **client:** add `JsonDictionary` identity methods ([8270f1e](https://github.com/cjavdev/nps-dotnet/commit/8270f1e7c13758df1bfb460a426121b136359b48))
* **internal:** `JsonElement` constant construction ([b47b3f0](https://github.com/cjavdev/nps-dotnet/commit/b47b3f096dabbac7754ee74700f5c045aa718ad0))

## 0.4.0 (2026-01-12)

Full Changelog: [v0.3.0...v0.4.0](https://github.com/cjavdev/nps-dotnet/compare/v0.3.0...v0.4.0)

### Features

* **api:** manual updates ([1d9419f](https://github.com/cjavdev/nps-dotnet/commit/1d9419f3bd84d81d5f1681bb43a46d7107f27df6))
* **api:** manual updates ([435e6a2](https://github.com/cjavdev/nps-dotnet/commit/435e6a23f0c3806ec6a85cad3a96b3583bc61513))
* **api:** manual updates ([8280c12](https://github.com/cjavdev/nps-dotnet/commit/8280c127a03d21ab0b9866f9ff6a8194453fd88a))
* **api:** manual updates ([c3805b5](https://github.com/cjavdev/nps-dotnet/commit/c3805b555f30944dd2742c8469a66b188db5bc32))
* **api:** manual updates ([a9a5ff3](https://github.com/cjavdev/nps-dotnet/commit/a9a5ff315b870f8e26fba2ddcc1b86b2b2085a47))
* **api:** manual updates ([577bbc4](https://github.com/cjavdev/nps-dotnet/commit/577bbc40df2e9ee2fcad60a0dedfdc0f97e5f62b))
* **client:** add more `ToString` implementations ([fde6bf9](https://github.com/cjavdev/nps-dotnet/commit/fde6bf98e4228b7628fcd698f082939e134e9b1c))
* **client:** support accessing raw responses ([ee3a8de](https://github.com/cjavdev/nps-dotnet/commit/ee3a8defe5e56fa487a03146b8563898fc6c7f3e))


### Bug Fixes

* **client:** copy path params in params copy constructors ([d18871f](https://github.com/cjavdev/nps-dotnet/commit/d18871f4cc76fdf2f34dc7b98570cc611daeb709))
* **internal:** remove redundant line ([0637faf](https://github.com/cjavdev/nps-dotnet/commit/0637fafeeee6170a19e598283c3937a8d2a713ac))
* **internal:** remove roundtrip tests for multipart params ([e0f05da](https://github.com/cjavdev/nps-dotnet/commit/e0f05dacd61703f6e6da0d7e8b9fc2508ce981f5))


### Documentation

* add raw responses to readme ([327651e](https://github.com/cjavdev/nps-dotnet/commit/327651e1f73ea12c2ff44028b8b991dacae26611))


### Refactors

* **client:** make unions implement `ModelBase` ([95e575a](https://github.com/cjavdev/nps-dotnet/commit/95e575ade72f631e37e224e3284d0b109a26f774))

## 0.3.0 (2026-01-07)

Full Changelog: [v0.2.0...v0.3.0](https://github.com/cjavdev/nps-dotnet/compare/v0.2.0...v0.3.0)

### Features

* **api:** manual updates ([17f4094](https://github.com/cjavdev/nps-dotnet/commit/17f4094cc44e3f4611c85cb3f6dce367ceade61a))

## 0.2.0 (2026-01-07)

Full Changelog: [v0.1.0...v0.2.0](https://github.com/cjavdev/nps-dotnet/compare/v0.1.0...v0.2.0)

### Features

* **api:** manual updates ([58dd83a](https://github.com/cjavdev/nps-dotnet/commit/58dd83ae4cd1291a2a58ac4a77a7c17149cb9722))
* **api:** manual updates ([6eee497](https://github.com/cjavdev/nps-dotnet/commit/6eee497fd5fe1c7e1f96b9612f3ff6e4107e6999))

## 0.1.0 (2026-01-07)

Full Changelog: [v0.0.1...v0.1.0](https://github.com/cjavdev/nps-dotnet/compare/v0.0.1...v0.1.0)

### Features

* **api:** manual updates ([101ecc4](https://github.com/cjavdev/nps-dotnet/commit/101ecc4f68970254aedf3a5519e84662660bf478))
* **api:** manual updates ([4063ada](https://github.com/cjavdev/nps-dotnet/commit/4063adabe7e3383205e305e056d9cffa3e3c7a14))


### Chores

* update SDK settings ([f6f9846](https://github.com/cjavdev/nps-dotnet/commit/f6f9846403359900407c3a49f4032a459c8f5e73))
