class Foo
    def self.new(*args, &blk)
        obj = allocate
        obj.initialize(*args, &blk)
        obj
    end
end

#https://pt.stackoverflow.com/q/341659/101
